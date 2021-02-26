using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Swagger.Controllers
{
    [SwaggerTag("Demo", "www.prueba.com" )]
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        /// <summary>
        /// Get string.
        /// </summary>
        /// <response code="401">Unauthorized. No se encuentra autorizado</response>
        /// <response code="200">Ok. Correcto</response>
        /// <response code="404">NotFound. No se encuentra</response>
        /// <response code="500">Error. Se produjo un error</response>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(void), 500)]
        public IActionResult GetString()
        {
            return Ok("Hi Word!");
        }
    }
}
