namespace LinkedInDemo.api.Orders.Interface
{
    public interface IOrdersProvider
    {
        public Task<List<LinkedInDemo.api.Orders.Db.Order>> GetOrdersAsync();
    }
}
