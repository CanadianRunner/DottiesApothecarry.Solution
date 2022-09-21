using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting; // In the lesson plan
using Microsoft.Extensions.Logging;

namespace DottiesApothecary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // **** THIS WAS APART OF THE SCAFFOLD BUILD ****
            CreateHostBuilder(args).Build().Run();
            // **** THIS IS WHAT THE LESSON PLAN DID ****
            // var host = new WebHostBuilder()
            //     .UseKestrel()
            //     .UseContentRoot(Directory.GetCurrentDirectory())
            //     .UseIISIntegration()
            //     .UseStartup<Startup>()
            //     .Build();

            // host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
