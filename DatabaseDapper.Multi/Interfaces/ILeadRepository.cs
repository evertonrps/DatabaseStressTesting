using DatabaseDapper.Multi.Entities;

namespace DatabaseDapper.Multi.Interfaces;

public interface ILeadRepository
{
    public Task<IEnumerable<Lead>> GetAll();
}