

namespace LinkedInDemo.Api.Products.Interface
{
    public interface IProductsProvider
    {
      public Task<List<LinkedInDemo.Api.Products.Db.Product>> GetProductsAsync();
    }
}
