using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TractorsWithColor.Models;
using TractorsWithColor.Services.Interfaces;

namespace TractorsWithColor.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TractorController : ControllerBase
    {
        private readonly ITractorService _tractorService;

        public TractorController(ITractorService tractorService)
        {
            _tractorService = tractorService;
        }

        [HttpPost()]
        public IActionResult CreateTractor([FromBody] PostTractorModel tractorModel)
        {
            _tractorService.AddTractor(tractorModel);
            return Ok(tractorModel);
        }
    }
}
