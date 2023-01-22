using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.API.Controllers
{
    [Route("api/[controller]")]
    public class DummyController : ControllerBase
    {
        public async Task<IActionResult> DummyMethod()
        {
            return Ok();
        }
    }
}
