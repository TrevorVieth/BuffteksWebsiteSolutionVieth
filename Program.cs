using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BuffteksWebsite.Models;

namespace BuffteksWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // //The Three ingredients of LINQ
            // //1, Create pr access a linear data structure that impliments IEnumerable
            // string[] names = new string []
            // {"Jeff", "Frank", "Kolton", "Ian", "Mike", "Gabby"};

            // //Develope a query
            // var namesFilteredShort = 
            //     from name in names
            //     where name.Length <= 4
            //     select name; 

            // string name1 = "asdaf";

            // //Execute a query
            // foreach(string name in names)
            // {
            //     Console.Write($"data is :{name}\n");
            // }


            var host = BuildWebHost(args);
            //BuildWebHost(args).Run();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    // Requires using MvcMovie.Models;
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
