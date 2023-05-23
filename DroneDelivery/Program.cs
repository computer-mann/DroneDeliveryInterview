
namespace DroneDelivery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            StartUp.ConfigureServices(builder.Services,builder.Configuration);

            var app = builder.Build();

            StartUp.Configure(app);

            app.Run();
        }
    }
}