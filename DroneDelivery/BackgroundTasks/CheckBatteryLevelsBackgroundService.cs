using DroneDelivery.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace DroneDelivery.BackgroundTasks
{
    public class CheckBatteryLevelsBackgroundService : BackgroundService
    {
        private IServiceProvider _serviceProvider;
        private readonly ILogger<CheckBatteryLevelsBackgroundService> logger;

        public CheckBatteryLevelsBackgroundService(ILogger<CheckBatteryLevelsBackgroundService> logger, IServiceProvider serviceProvider)
        {
            
            this.logger = logger;
            _serviceProvider = serviceProvider;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using(IServiceScope serviceScope = _serviceProvider.CreateScope())
            {
                logger.LogInformation("About to start checking for battery levels");
                DroneDeliveryDbContext _dbContext = serviceScope.ServiceProvider.GetRequiredService<DroneDeliveryDbContext>();
                while (!stoppingToken.IsCancellationRequested)
                {
                    var dataList = _dbContext.Drones.Select(p => new { p.SerialNumber, p.BatteryCapacity });
                    foreach (var data in dataList)
                    {
                        logger.LogInformation("Battery level for {droneSerialnumber} at {time} was {batteryLevel}", data.SerialNumber, DateTime.Now.ToString(), data.BatteryCapacity);
                    }
                    await Task.Delay(4000);
                }                
            }

        }
        //public record 
    }
}
