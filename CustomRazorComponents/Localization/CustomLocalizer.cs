



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
    }
}
