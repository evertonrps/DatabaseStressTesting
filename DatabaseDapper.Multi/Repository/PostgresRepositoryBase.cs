using System.Data;
using DatabaseDapper.Multi.Enums;
using DatabaseDapper.Multi.Interfaces;

namespace DatabaseDapper.Multi.Repository;

public abstract class PostgresRepositoryBase :IPostgresRepositoryBase
{
    public IDbConnection DbConnection { get; private set; }

    public PostgresRepositoryBase(IDbConnectionFactory dbConnectionFactory)
    {
        DbConnection = dbConnectionFactory.CreateDbConnection(EDatabaseConnectionName.PostgresConnection);
    }
}