namespace WinForms.Await.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
        public decimal Qty { get; set; } = 0M;
        public decimal Price { get; set; } = 0M;
        public decimal Total => this.Qty * this.Price;

        public Order(int id, string product, int qty, decimal price)
        {
            this.OrderId = id;
            this.Product = product;
            this.Qty = (decimal)qty;
            this.Price = price;
        }
    }
}
