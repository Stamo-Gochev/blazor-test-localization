﻿using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace CustomComponents.Components
{
    public partial class LocalizedComponent : ComponentBase
    {
        [Inject]
        public IStringLocalizer<LocalizedComponent> Localizer { get; set; }
        //public IStringLocalizer Localizer { get; set; }

        public string Title { get; set; }

        protected override void OnInitialized()
        {

            base.OnInitialized();
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {

            }

            Title = Localizer["key1"];
            base.OnAfterRender(firstRender);
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }

    }
}
