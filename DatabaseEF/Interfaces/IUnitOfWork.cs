using DatabaseEF.Entitites;

namespace DatabaseEF.Interfaces;

public interface IUnitOfWork
{
    IRepository<Lead> LeadRepository { get; }
    void Commit();
}