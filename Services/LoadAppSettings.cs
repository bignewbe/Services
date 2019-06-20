using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Services
{
    public class LoadAppSettings
    {
        public static IConfigurationRoot LoadSettings()
        {
            var env = Environment.GetEnvironmentVariable("ENV");
            var baseconfigfile = "appsettings.json";
            var configfile = string.Empty;
            if (env == null || env == "DEV")
                configfile = "appsettings.DEV.json";
            //else if (env == "PRD")
            //    configfile = "appsettings.PRD.json";
            //else if (env == "DKR")
            //    configfile = "appsettings.DKR.json";
            else
                configfile = $"appsettings.{env}.json";

            var configFolder = Environment.GetEnvironmentVariable("ENV_CONFIG_FOLDER");
            if (string.IsNullOrEmpty(configFolder))  //serch upwards for folder "appsettings"
            {
                int count = 0;
                configFolder = "appsettings";
                while (count++ < 10)
                {
                    configFolder = Path.Combine("..", configFolder);
                    if (Directory.Exists(configFolder)) break;
                }
            }

            baseconfigfile = Path.GetFullPath(Path.Combine(configFolder, baseconfigfile));
            configfile = Path.GetFullPath(Path.Combine(configFolder, configfile));
            if (!File.Exists(baseconfigfile))
            {
                Console.WriteLine($"{baseconfigfile} does not exist!");
                return null;
            }
            if (!File.Exists(configfile))
            {
                Console.WriteLine($"{configfile} does not exist!");
                return null;
            }

            Console.WriteLine($"Environment = {env}");
            Console.WriteLine($"Base configuration file = {baseconfigfile}");
            Console.WriteLine($"Configuration file = {configfile}");

            /////////////////////////////////////////////////////////////////////////////////
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(baseconfigfile)
                .AddJsonFile(configfile, optional: false)
                .Build();

            return config;
        }

    }
}
