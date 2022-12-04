using DatabaseEF.Entitites;
using DatabaseEF.Interfaces;

namespace DatabaseEF.Repositories;

public class LeadRepository :ILeadRepository
{
    public Task<IEnumerable<Lead>> GetAll()
    {
        throw new NotImplementedException();
    }
}