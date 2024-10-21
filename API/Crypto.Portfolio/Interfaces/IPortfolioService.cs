using Crypto.Portfolio.Models;

namespace Crypto.Portfolio.Interfaces
{
    public interface IPortfolioService
    {
        public Task<PortfolioSummary> Process(PortfolioItem[] portfolioItems);
    }
}
