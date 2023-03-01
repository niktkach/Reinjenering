using System;
using System.Collections.Generic;

namespace Lab1reinjenering
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var order = new Order("John Doe",
            new List<Product>
            {
                new Product("Pulled Pork", 6.99m, 0.5m, PricingMethod.PerPound),
                new Product("Coke", 3m, 2, PricingMethod.PerItem)
            });
            var orderSummary = order.GetOrderSummary();

            Console.WriteLine(orderSummary);
            Console.WriteLine("Total Price: $" + order.TotalPrice);

            Console.ReadKey();
        }
    }
}