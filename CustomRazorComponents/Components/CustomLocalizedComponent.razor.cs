using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace CustomRazorComponents.Components
{
    public partial class CustomLocalizedComponent : ComponentBase
    {
        //[Inject]
        //public IStringLocalizer<CustomLocalizedComponent> Localizer { get; set; }
        //public IStringLocalizer Localizer { get; set; }

        public string Title { get; set; }

        protected override void OnInitialized()
        {

            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Title = Localizer["key1"];
            base.OnAfterRender(firstRender);
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }

    }
}
