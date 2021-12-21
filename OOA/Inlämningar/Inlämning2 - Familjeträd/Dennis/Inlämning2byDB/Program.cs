using Inlämning2byDB.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Inlämning2byDB
{
        /*
        När man startar programmet kommer en databas att skapas! Namnet på databasen kommer att vara det namnet vi angett i "appsettings.json" (Går att ändra till vad vi vill).
        När databasen har skapats kan vi göra en "Add-Migration" och sedan en "Update-Database" Manuellt. 
        Jag har valt att göra The Simpsons familjeträd, vid start av programmet kommer hela familjeträdet seedas med hjälp av "Data/DBInitializer" där vi angett hela deras släkt.
        Sedan är det bara att leka runt! :)
        */
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreateDbIfNotExists(host);
            host.Run();
        }
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    DBInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
