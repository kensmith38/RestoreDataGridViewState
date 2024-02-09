using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RestoreDataGridViewState
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        /// <summary>
        /// Create a host builder to build the service provider
        /// </summary>
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IPatientRepository, MockPatientRepository>();
                    services.AddTransient<Form1>();
                });
        }
    }
}