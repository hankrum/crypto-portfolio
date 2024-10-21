namespace Crypto.Portfolio.Models
{
    public class PortfolioSummary
    {
        public decimal InitialValue { get; set; }

        public PortfolioResultItem[] PortfolioResultItems { get; set; }

        public decimal PriceChange { get; set; }

    }
}
