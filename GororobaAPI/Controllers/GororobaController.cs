using GororobaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GororobaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GororobaController : ControllerBase
    {
        private readonly SpoonacularApiService _service;

        public GororobaController(SpoonacularApiService service)
        {
            _service = service;
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetRecipesByIngredient([FromQuery] string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return BadRequest("Search cannot be empty");

            var sanitizedQuery = query.Trim().ToLower();

            var recipes = await _service.GetRecipesByIngredient(sanitizedQuery);
            return Ok(recipes);
        }

        [HttpGet("details/{recipeId}")]
        public async Task<IActionResult> GetRecipeDetails([FromRoute] int recipeId)
        {
            var recipeDetails = await _service.GetRecipeDetails(recipeId);

            if (recipeDetails == null)
                return BadRequest("Recipe details not found");

            return Ok(recipeDetails);
        }
    }
}
