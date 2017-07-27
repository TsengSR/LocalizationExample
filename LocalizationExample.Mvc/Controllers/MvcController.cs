using System;
using System.Collections.Generic;
using System.Text;
using LocalizationExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationExample.Mvc.Controllers
{
    [Route("api/[controller]")]
    public class MvcController : Controller
    {
        private readonly IStringLocalizer<SharedMvcResources> sharedLocalization;

        public MvcController(IStringLocalizer<SharedMvcResources> sharedLocalization)
        {
            this.sharedLocalization = sharedLocalization ?? throw new ArgumentNullException(nameof(sharedLocalization));
        }
        public string Get()
        {
            return sharedLocalization["Hello Mvc"];
        }
    }
}
