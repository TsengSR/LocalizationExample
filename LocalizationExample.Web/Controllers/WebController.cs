using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationExample.Web.Controllers
{
    [Route("api/[controller]")]
    public class WebController : Controller
    {
        private IStringLocalizer<SharedResources> sharedLocalizer;

        public WebController(IStringLocalizer<SharedResources> sharedLocalizer)
        {
            this.sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public string Get()
        {
            return sharedLocalizer["Hello Web"];
        }
    }
}
