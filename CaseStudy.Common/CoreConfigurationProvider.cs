using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System;

namespace CaseStudy.Common
{
    public static class CoreConfigurationProvider
    {
        public static IConfiguration BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", false, true)
              .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true);

            var configuration = builder.Build();

            return configuration;
        }
    }
}
