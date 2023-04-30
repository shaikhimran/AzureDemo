namespace LinkedInDemo.api.Orders.Db
{
    public class Order
    {
        public int Id { get; set; } 
        public int CustomerId  { get; set; }
        public decimal Total { get; set; }
        public List<OrderItem> Items { get; set; }
    }


}

public class OrderItem
{
    public int Id { get;set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
}
