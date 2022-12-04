using Microsoft.Extensions.Configuration;

namespace SharedKernel;

public class ConfigurationFactory
{
    public static IConfiguration GetConfiguration()
        => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
}