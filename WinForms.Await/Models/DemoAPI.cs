using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinForms.Await.Models
{
    public class DemoAPI
    {
        private List<Order> orders;

        public DemoAPI()
        {
            this.orders = new List<Order>()
            {
                new Order(101, "Essential.NET", 2, 35M),
                new Order(102, "Programming ASP.NET", 1, 45M),
                new Order(103, "LINQ in C#", 2, 30M),
                new Order(104, "ASP.NET MVC", 1, 33M),
                new Order(105, "Code Complete", 1, 25M),
                new Order(106, "Inside C#", 1, 30M),
                new Order(107, "C# in Depth", 1, 20M),
                new Order(108, "WPF 4", 1, 35M),
                new Order(109, "ASP.NET AJAX", 1, 30M),
                new Order(110, "Windows Forms Programming in C#", 1, 40M),
                new Order(111, "LINQ in C#", 2, 30M),
                new Order(112, "Programming ASP.NET", 1, 45M),
                new Order(113, "C# in Depth", 1, 20M)
            };
        }

        public List<Order> GetLast5Orders()
        {
            IEnumerable<Order> last5Orders = this.orders.OrderByDescending(x => x.OrderId).Take(5);
            Thread.Sleep(4000);

            return last5Orders.ToList<Order>();
        }

        public decimal GetOrderTotalPrice()
        {
            decimal orderTotalPrice = this.orders.Sum(x => x.Total);
            Thread.Sleep(1500);

            return orderTotalPrice;
        }

        public decimal GetOrderTotalQty()
        {
            decimal orderTotalQty = this.orders.Sum(x => x.Qty);
            Thread.Sleep(1000);

            return orderTotalQty;
        }
    }
}
