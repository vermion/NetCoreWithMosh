using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace NetCoreWithMosh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    // For ASP .NET Core 2.0
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var host = BuildWebHost(args);

    //        host.Run();
    //    }

    //    // Tools will use this to get application services
    //    public static IWebHost BuildWebHost(string[] args) =>
    //        new WebHostBuilder()
    //            .UseKestrel()
    //            .UseContentRoot(Directory.GetCurrentDirectory())
    //            .UseIISIntegration()
    //            .UseStartup<Startup>()
    //            .Build();
    //}
}




