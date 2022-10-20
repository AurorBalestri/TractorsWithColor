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
            var tractorToAdd = _tractorService.AddTractor(tractorModel);
            return Ok(tractorToAdd);
        }

        [HttpGet("gettractorbyid/{id}")]
        public IActionResult GetTractorDetails(int id)
        {
            var tractorWithDetails = _tractorService.GetTractorDetails(id);
            if (tractorWithDetails == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(tractorWithDetails);
            }
        }

        [HttpGet("gattractorbycolor/{color}")]
        public IActionResult GetAllTractorsByColor(string color)
        {
            var tractorFetchedOnColor = _tractorService.GetAllTractorsByColor(color);
            if (tractorFetchedOnColor == null)
            {
                return NotFound();
            } 
            else
            {
                return Ok(tractorFetchedOnColor);
            }
        }
    }
}
