            if (body != null && "true".Equals(module.GetEffectiveSetting("core.autocrlf"), StringComparison.InvariantCultureIgnoreCase))
            if (reset && body != null && "true".Equals(module.GetEffectiveSetting("core.autocrlf"), StringComparison.InvariantCultureIgnoreCase))
                result = result.Combine("\n", Application.ProductName + " " + Settings.GitExtensionsVersionString);