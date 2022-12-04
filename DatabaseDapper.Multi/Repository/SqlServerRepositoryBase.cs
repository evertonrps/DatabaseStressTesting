// using System.Data;
// using DatabaseDapper.Multi.Enums;
// using DatabaseDapper.Multi.Interfaces;
//
// namespace DatabaseDapper.Multi.Repository;
//
// public abstract class SqlServerRepositoryBase :ISqlServerRepositoryBase
// {
//     public IDbConnection DbConnection { get; }
//
//     public SqlServerRepositoryBase(IDbConnectionFactory dbConnectionFactory)
//     {
//         DbConnection = dbConnectionFactory.CreateDbConnection(EDatabaseConnectionName.SqlConnection);
//     }
// }