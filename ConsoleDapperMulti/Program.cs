// See https://aka.ms/new-console-template for more information

using System.Data;
using DatabaseConsoleApp;
using DatabaseDapper.Multi.Enums;
using DatabaseDapper.Multi.Interfaces;
using DatabaseDapper.Multi.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using SharedKernel;


var config = ConfigurationFactory.GetConfiguration();

var connectDict = new Dictionary<EDatabaseConnectionName, string>
{
   // { EDatabaseConnectionName.OracleConnection, config.GetConnectionString("OracleConnection") },
    { EDatabaseConnectionName.PostgresConnection, config.GetConnectionString("PostgresConnection") },
    //{ EDatabaseConnectionName.SqlConnection, config.GetConnectionString("SqlConnection") }
};

/*
 *
 *             string dbConnectionString = this.Configuration.GetConnectionString("dbConnection1");
            
            // Inject IDbConnection, with implementation from SqlConnection class.
            services.AddTransient<IDbConnection>((sp) => new SqlConnection(dbConnectionString));

            // Register your regular repositories
            services.AddScoped<IDiameterRepository, DiameterRepository>();
 */


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddSingleton<IDictionary<EDatabaseConnectionName, string>>(connectDict)
            .AddTransient<IDbConnectionFactory, DapperDbConnectionFactory>()
            .AddScoped<ILeadRepository, LeadRepository>()
            .AddTransient<ConsoleApp>()
    )
    .Build();
host.Services.GetService<ConsoleApp>()!.Run();





await host.RunAsync();