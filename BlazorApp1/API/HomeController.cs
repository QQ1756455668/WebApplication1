using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Authorize]
        [HttpGet, Route("GetChatRecordList")]
        public async Task<IActionResult> GetChatRecordListAsync()
        {
            return new JsonResult("fefe");
        }
    }
}
