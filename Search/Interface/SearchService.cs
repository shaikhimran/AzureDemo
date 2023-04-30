using Search.Models;

namespace Search.Interface
{
    public interface ISearchService 
    {
        public Task<(bool IsSuccess, dynamic searchResult)> SearchAsync(SearchTerm searchTerm);
    }
}
