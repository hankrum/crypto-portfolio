namespace Crypto.Portfolio.Models
{
    public class PortfolioItem
    {
        public required string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal BuyPrice { get; set; }
    }
}
