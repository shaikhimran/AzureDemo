using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search.Interface;
using Search.Models;

namespace Search.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService searchService;
        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync(SearchTerm term)
        {
             var result = await searchService.SearchAsync(term);
            if (result.IsSuccess)
            {
                return Ok(result.searchResult);  
            }

            return NotFound();
        }
    }
}
