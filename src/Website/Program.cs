using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
// Add Microsoft.Extensions.Configuration.CommandLine

// https://docs.cloudfoundry.org/buildpacks/dotnet-core/index.html
namespace Website
{
    // Lock the .NET Framework to a minor version. Do not lock to a patch version. Buildpacks contain only the two most recent patch versions of each minor version
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        // The port will default to what is configure in launchSettings.json when running locally
        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddCommandLine(args)   // Allows the buildpack to pass the correct port from $PORT to the app when running the initial startup command
                .Build();

            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
        }
            
    }
}
