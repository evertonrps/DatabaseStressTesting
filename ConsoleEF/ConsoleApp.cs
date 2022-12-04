using DatabaseEF.Entitites;
using DatabaseEF.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleEF;

public class ConsoleApp
{
    private readonly ILogger<ConsoleApp> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private SpinWait spinWait;

    public ConsoleApp(ILogger<ConsoleApp> logger,
        IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
        spinWait = new SpinWait();
    }
    public async void Run()
    {
        _logger.LogInformation("Iniciando Consultas no banco...");

        do
        {
  
           await  ConsultaLeads(); 
         
        } while (true);
        

        //_logger.LogInformation("Consultas finalizadas !!!");
    }
    
    private async Task ConsultaLeads()
    {
        try
        {
            var leads =  _unitOfWork.LeadRepository.GetAll();
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