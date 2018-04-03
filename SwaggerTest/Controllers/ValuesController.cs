using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Models;

namespace SwaggerTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        /// <summary>
        /// Gets some model.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(SomeModel), 200)]
        public SomeModel Get()
        {
            return new SomeModel { MyProperty1 = 1, MyProperty2 = "Test" };
        }
    }
}
