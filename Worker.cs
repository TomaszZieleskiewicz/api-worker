using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace restapi
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public int Counter  { get; private set; } = 0;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation($"Worker running for {Counter} time");
                Counter++;
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
