using LinkedInDemo.api.Orders.Db;
using LinkedInDemo.api.Orders.Interface;

namespace LinkedInDemo.api.Orders.Provider
{
    public class OrderDataProvidercs : IOrdersProvider
    {
        private readonly OrderDbContext dbContext;

        public OrderDataProvidercs(OrderDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.SeedData();
        }
        private void SeedData()
        {
            if (!dbContext.Orders.Any())
            {
                dbContext.Orders.Add(new Db.Order() { Id = 1, CustomerId = 1, Total = 203, Items = new List<OrderItem> { new OrderItem { Id = 1, ProductId = 1, Quantity = 10, UnitPrice = 10 }, new OrderItem { Id = 2, ProductId = 2, Quantity = 12, UnitPrice = 56 } } });
                dbContext.Orders.Add(new Db.Order() { Id = 2, CustomerId = 1, Total = 45, Items = new List<OrderItem> { new OrderItem { Id = 3, ProductId = 2, Quantity = 12, UnitPrice = 3 }, new OrderItem { Id =4, ProductId = 4, Quantity = 44, UnitPrice = 2 } } });
                dbContext.Orders.Add(new Db.Order() { Id = 3, CustomerId = 2, Total = 67, Items = new List<OrderItem> { new OrderItem { Id = 5, ProductId = 3, Quantity = 45, UnitPrice = 7 }, new OrderItem { Id = 6, ProductId = 2, Quantity = 6, UnitPrice = 5 } } });
                dbContext.Orders.Add(new Db.Order() { Id = 4, CustomerId = 2, Total = 123, Items = new List<OrderItem> { new OrderItem { Id = 7, ProductId = 2, Quantity = 33, UnitPrice = 23 }, new OrderItem { Id = 8, ProductId = 3, Quantity = 88, UnitPrice = 7 } } });
                dbContext.Orders.Add(new Db.Order() { Id = 5, CustomerId = 3, Total = 890, Items = new List<OrderItem> { new OrderItem { Id = 9, ProductId = 2, Quantity = 21, UnitPrice = 67 }, new OrderItem { Id = 10, ProductId = 6, Quantity = 90, UnitPrice = 8 } } });
                dbContext.SaveChanges();
            }
        }
        public Task<List<Order>> GetOrdersAsync()
        {
            var orders = dbContext.Orders.ToList();
            return Task.FromResult(orders);
        }
    }
}
