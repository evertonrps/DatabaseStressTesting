using DatabaseDapper.Multi.Entities;

namespace DatabaseDapper.Multi.Interfaces;

public interface ICustomerRepository
{
    public IEnumerable<Customer> GetAll();
}