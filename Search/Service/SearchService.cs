using Search.Interface;
using Search.Models;

namespace Search.Service
{
    public class SearchService : ISearchService
    {

        public SearchService()
        {

        }
         async Task<(bool IsSuccess, dynamic searchResult)> ISearchService.SearchAsync(SearchTerm searchTerm)
        {
            await Task.Delay(1);

            return (true, new { Message = "Hello" });
        }
    }
}
