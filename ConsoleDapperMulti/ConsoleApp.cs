using DatabaseDapper.Multi.Interfaces;
using Microsoft.Extensions.Logging;

namespace DatabaseConsoleApp;

public class ConsoleApp
{
    private readonly ILogger<ConsoleApp> _logger;
    private readonly ILeadRepository _leadRepository;
    private SpinWait spinWait;

    public ConsoleApp(ILogger<ConsoleApp> logger,
        ILeadRepository leadRepository)
    {
        _logger = logger;
        _leadRepository = leadRepository;
        spinWait = new SpinWait();
    }

    public async void Run()
    {
        _logger.LogInformation("Iniciando Consultas no banco...");

        do
        {
          //_= Task.Run(()=>
           //{
               await  ConsultaLeads(); 
           //});
        } while (true);
        

        _logger.LogInformation("Consultas finalizadas !!!");
    }

    private async Task ConsultaLeads()
    {
        try
        {
            var leads = await _leadRepository.GetAll();
            if (leads.Any())
            {
                foreach (var lead in leads)
                {
                    _logger.LogInformation($"Data: {DateTime.Now} {lead.Id} {lead.Name}");
                }
            }

            spinWait.SpinOnce();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Falha durante execução {ex.Message}");
        }
    }
}