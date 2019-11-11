using System;

namespace CustomRazorComponents.Localization
{
    public class CustomLocalizer : ICustomLocalizer
    {

        public virtual string GetString(string key)
        {
            var result = CustomRazorComponents.Resources.Components.CustomLocalizedComponent.ResourceManager.GetString(key,
                CustomRazorComponents.Resources.Components.CustomLocalizedComponent.Culture
            );

            return "default localizer |" + result;
        }

        public virtual string this[string name]
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
