using System.Data;

namespace DatabaseDapper.Multi.Interfaces;

public interface IPostgresRepositoryBase
{
    public IDbConnection DbConnection { get; }
}