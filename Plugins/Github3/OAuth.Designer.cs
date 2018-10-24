
namespace GitHub3
{
    partial class OAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView1 = new Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.CausesValidation = false;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(980, 600);
            this.webView1.TabIndex = 0;
            this.webView1.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.webView1_NavigationCompleted);
            this.webView1.NavigationStarting += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs>(this.webView1_NavigationStarting);
            // 
            // OAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.webView1);
            this.Name = "OAuth";
            this.ShowIcon = false;
            this.Text = "GitHub Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView webView1;
    }
}