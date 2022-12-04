using DatabaseDapper.Single.Entities;

namespace DatabaseDapper.Single.Interfaces;

public interface ILeadRepository
{
    Task<IEnumerable<Lead>> GetAll();
}