using Microsoft.AspNetCore.Mvc;

namespace Nameless.WebApplication.Web.Controllers {

    [ApiController]
    [ApiVersion("1")]
    [Area("values")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public sealed class ValuesController : ControllerBase {

        #region Public Methods

        [HttpGet]
        public IActionResult Get() {
            return Ok(new[] { "Value" });
        }

        #endregion
    }
}