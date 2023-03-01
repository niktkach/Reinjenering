namespace Lab1reinjenering
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal? Weight { get; set; }
        public int? Quantity { get; set; }
        public PricingMethod PricingMethod { get; set; }

        public Product(string productName, decimal price, decimal? weight, PricingMethod pricingMethod)
        {
            ProductName = productName;
            Price = price;
            Weight = weight;
            Quantity = null;
            PricingMethod = pricingMethod;
        }

        public Product(string productName, decimal price, int quantity, PricingMethod pricingMethod)
        {
            ProductName = productName;
            Price = price;
            Weight = null;
            Quantity = quantity;
            PricingMethod = pricingMethod;
        }

        public decimal? GetProductPrice()
        {
            switch (PricingMethod)
            {
                case PricingMethod.PerPound:
                    return Weight.Value * Price;

                case PricingMethod.PerItem:
                    return Quantity.Value * Price;

                default:
                    return null;
            }
        }

        public string GetProductPriceInfo()
        {
            switch (PricingMethod)
            {
                case PricingMethod.PerPound:
                    return Weight.Value + " pounds at $" + Price + " per pound = $" + GetProductPrice();

                case PricingMethod.PerItem:
                    return Quantity.Value + " items at $" + Price + " each = $" + GetProductPrice();

                default:
                    return "Not implemented pricing method";
            }
        }
    }
}