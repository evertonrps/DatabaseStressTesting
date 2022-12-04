using System.Data;
using ConsoleDapperSingle;
using DatabaseDapper.Single.Interfaces;
using DatabaseDapper.Single.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using SharedKernel;


var config = ConfigurationFactory.GetConfiguration();

#region DapperSingle
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection(config.GetConnectionString("PostgresConnection")))
            .AddScoped< ILeadRepository, LeadRepository>()
            .AddTransient<ConsoleApp>()
    )
    .Build();
host.Services.GetService<ConsoleApp>()!.Run();
#endregion

await host.RunAsync();