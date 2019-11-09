using CustomRazorComponents.Localization;

namespace blazor_test_localization.Services
{
    public class CustomLocalizerService : CustomLocalizer
    {
        public override string GetString(string key)
        {
            return "custom localization |" + base.GetString(key);
        }
    }
}
