using Microsoft.AspNetCore.Mvc;

namespace Nameless.WebApplication.Web.Areas.Values.Controllers {

    [ApiController]
    [ApiVersion("1")]
    [Area("values")]
    [Route("api/v{version:apiVersion}/[area]/[controller]")]
    public sealed class ValuesController : ControllerBase {

        #region Public Methods

        [HttpGet]
        public IActionResult Get() {
            return Ok(new[] { "Area_Value" });
        }

        #endregion
    }
}
