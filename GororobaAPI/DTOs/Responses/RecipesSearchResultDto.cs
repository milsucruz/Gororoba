using GororobaAPI.DTOs.Requests;

namespace GororobaAPI.DTOs.Responses
{
    public class RecipesSearchResultDto
    {
        public List<RecipesSearchDto> Results { get; set; } = new();

        public int Offset { get; set; }

        public int Number { get; set; }

        public int TotalResults { get; set; }
    }
}
