



using ConsoleEF;
using DatabaseEF.Context;
using DatabaseEF.Interfaces;
using DatabaseEF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SharedKernel;

var config = ConfigurationFactory.GetConfiguration();

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddScoped<IUnitOfWork,UnitOfWork>()
            .AddDbContext<MyDbContext>(option=> option.UseNpgsql(connectionString:config.GetConnectionString("PostgresConnection")))
            .AddTransient<ConsoleApp>()
    )
    .Build();
host.Services.GetService<ConsoleApp>()!.Run();