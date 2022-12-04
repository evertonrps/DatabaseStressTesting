using System.Data;

namespace DatabaseDapper.Multi.Interfaces;

public interface ISqlServerRepositoryBase
{
    public IDbConnection DbConnection { get; }
}