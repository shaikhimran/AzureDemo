using LinkedInDemo.Api.Products.Db;
using LinkedInDemo.Api.Products.Interface;

namespace LinkedInDemo.Api.Products.Providers
{
    public class ProductProvider : IProductsProvider
    {
        private readonly ProductsDbContext dbContext;

        public ProductProvider(ProductsDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.SeedData();
        }

        private void SeedData()
        {
            if (!dbContext.Products.Any())
            {
                dbContext.Products.Add(new Db.Product() { Id = 1, Name = "Keyboard", Price = 203,Inventory=100 });
                dbContext.Products.Add(new Db.Product() { Id = 2, Name = "Mouse", Price = 34, Inventory = 100 });
                dbContext.Products.Add(new Db.Product() { Id = 3, Name = "Monitor", Price = 56, Inventory = 100 });
                dbContext.Products.Add(new Db.Product() { Id = 4, Name = "CPU", Price = 76, Inventory = 100 });
                dbContext.Products.Add(new Db.Product() { Id = 5, Name = "Bluetooth", Price = 12, Inventory = 100 });
                dbContext.SaveChanges();
            }
        }
        public Task<List<Db.Product>> GetProductsAsync()
        {
            var products = dbContext.Products.ToList();
            return Task.FromResult(products);
        }
    }
}
