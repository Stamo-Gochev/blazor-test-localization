using CustomRazorComponents.Localization;
using System;

namespace blazor_test_localization.Services
{
    public class CustomLocalizerService : CustomLocalizer
    {
        public override string GetString(string key)
        {
            var result = GetStringFromResource(key);
            return $"custom localization with override | {result} |" + base.GetString(key);
        }

        public string GetStringFromResource(string key)
        {
            var result = blazor_test_localization.Resources.Components.CustomLocalizedComponent.ResourceManager.GetString(key,
                blazor_test_localization.Resources.Components.CustomLocalizedComponent.Culture
            );

            return result;
        }

        public override string this[string name]
        {
            get
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return GetString(name);
            }
        }

    }
}
