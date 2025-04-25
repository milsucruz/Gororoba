using GororobaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GororobaAPI.Controllers
{
    public class GororobaController : ControllerBase
    {
        private readonly SpoonacularApiService _service;

        public GororobaController(SpoonacularApiService service)
        {
            _service = service;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string ingredient)
        {
            var recipes = await _service.SearchByIngredient(ingredient);

            return Ok(recipes);
        }
    }
}
