



namespace CustomRazorComponents.Localization
{
    public class CustomLocalizer : ICustomLocalizer
    {
        public virtual string GetString(string key)
        {
            return "default custom localizer";
        }
    }
}
