using Crypto.Portfolio.Interfaces;
using Crypto.Portfolio.Models;

namespace Crypto.Portfolio.Services
{
    public class PortfolioService : IPortfolioService
    {
        public async Task<PortfolioSummary> Process(PortfolioItem[] portfolioItems)
        {
            return new PortfolioSummary();
        }
    }
}
