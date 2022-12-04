using System.Data;
using DatabaseDapper.Multi.Enums;

namespace DatabaseDapper.Multi.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection CreateDbConnection(EDatabaseConnectionName connectionName);
}