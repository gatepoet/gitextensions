using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Git.hub;

namespace GitHub3
{
    public partial class OAuth : Form
    {
        public OAuth()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                string url = "https://github.com/login/oauth/authorize?client_id=" + GitHubApiInfo.client_id + "&scope=repo,public_repo";
                webView1.Navigate(url);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(this, "Failure starting WebBrowser.");
            }
        }

        private bool _gotToken;

        private void webView1_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            CheckAuth(e.Uri);
        }

        private void webView1_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            CheckAuth(e.Uri);
        }

        private static Dictionary<string, string> GetParams(string uri)
        {
            var matches = Regex.Matches(uri, @"[\?&](([^&=]+)=([^&=#]*))", RegexOptions.Compiled);
            return matches.Cast<Match>().ToDictionary(
                m => Uri.UnescapeDataString(m.Groups[2].Value),
                m => Uri.UnescapeDataString(m.Groups[3].Value));
        }

        public void CheckAuth(Uri uri)
        {
            if (_gotToken)
            {
                return;
            }

            var queryParams = GetParams(uri.Query);
            if (queryParams.TryGetValue("code", out var code))
            {
                Hide();
                Close();
                string token = OAuth2Helper.requestToken(GitHubApiInfo.client_id, GitHubApiInfo.client_secret, code);
                if (token == null)
                {
                    return;
                }

                _gotToken = true;

                GitHubLoginInfo.OAuthToken = token;

                MessageBox.Show(Owner, "Successfully retrieved OAuth token.", "GitHub Authorization");
            }
        }
    }
}
