using DatabaseDapper.Multi.Entities;
using DatabaseDapper.Multi.Interfaces;
using Dapper;

namespace DatabaseDapper.Multi.Repository;

public class LeadRepository : PostgresRepositoryBase,ILeadRepository
{
    public LeadRepository(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory)
    {
    }

    public async  Task<IEnumerable<Lead>> GetAll()
    {
        try
        {
            string sql = "SELECT id, name, age, createdat, updatedat FROM public.lead";
            
            var leads =  await base.DbConnection.QueryAsync<Lead>(sql);
            return leads;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}