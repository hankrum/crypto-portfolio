using Crypto.Portfolio.Infrastructure;
using Crypto.Portfolio.Interfaces;
using Crypto.Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crypto.Portfolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly ILogger<PortfolioController> _logger;
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(ILogger<PortfolioController> logger, IPortfolioService portfolioService)
        {
            _logger = Guard.GetNotNullArgument(logger, nameof(logger));
            _portfolioService = Guard.GetNotNullArgument(portfolioService, nameof(portfolioService));
        }

        [HttpPost]
        public async Task<ActionResult<PortfolioSummary>> Post(PortfolioItem[] portfolioItems)
        {
            Guard.ArgumentNotNull(portfolioItems, nameof(portfolioItems));

            var result = await _portfolioService.Process(portfolioItems);

            return Ok(result);
        }
    }
}
