using System.Data;
using DatabaseDapper.Multi.Enums;
using DatabaseDapper.Multi.Interfaces;
using Npgsql;

namespace DatabaseDapper.Multi.Repository;

public class DapperDbConnectionFactory:IDbConnectionFactory
{
    private readonly IDictionary<EDatabaseConnectionName, string> _connectionDictionary;
    
    public DapperDbConnectionFactory(IDictionary<EDatabaseConnectionName, string> connectionDictionary)
    {
        _connectionDictionary = connectionDictionary;
    }
    

    public IDbConnection CreateDbConnection(EDatabaseConnectionName connectionName)
    {
        string connectionString = null;
        if (_connectionDictionary.TryGetValue(connectionName, out connectionString))
        {
            try
            {
                return new NpgsqlConnection(connectionString);
                //return new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgrespw;Database=postgres");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        throw new ArgumentException("Invalid ConnectionString");
    }
}