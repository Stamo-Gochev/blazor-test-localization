﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_test_localization.Components
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
