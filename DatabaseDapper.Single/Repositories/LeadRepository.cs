using System.Data;
using DatabaseDapper.Single.Entities;
using DatabaseDapper.Single.Interfaces;
using Microsoft.Extensions.Logging;
using Dapper;

namespace DatabaseDapper.Single.Repositories;

public class LeadRepository : ILeadRepository
{
    private readonly IDbConnection _dbConnection;
    private readonly ILogger<LeadRepository> _logger;

    public LeadRepository(IDbConnection dbConnection, ILogger<LeadRepository> logger)
    {
        _dbConnection = dbConnection;
        _logger = logger;
    }

    public async Task<IEnumerable<Lead>> GetAll()
    {
        try
        {
            string sql = "SELECT id, name, age, createdat, updatedat FROM public.lead";
            return await _dbConnection.QueryAsync<Lead>(sql);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Falha ao obter leads");
            throw;
        }
    }
}