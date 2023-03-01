using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1reinjenering
{
    public class Order
    {
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal? TotalPrice { get; set; }

        public Order(string customerName, List<Product> products)
        {
            CustomerName = customerName;
            Products = products;
            TotalPrice = 0m;
        }

        public string GetOrderSummary()
        {
            var orderSummary = "ORDER SUMMARY FOR " + CustomerName + ": \r\n";

            foreach (var orderProduct in Products)
            {
                orderSummary += orderProduct.ProductName + " ";
                orderSummary += orderProduct.GetProductPriceInfo() + "\r\n";
                TotalPrice += orderProduct.GetProductPrice();
            }

            return orderSummary;
        }
    }
}
