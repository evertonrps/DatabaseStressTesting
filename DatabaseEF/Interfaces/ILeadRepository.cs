using DatabaseEF.Entitites;

namespace DatabaseEF.Interfaces;

public interface ILeadRepository
{
    Task<IEnumerable<Lead>> GetAll();
}