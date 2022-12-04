using DatabaseEF.Context;
using DatabaseEF.Entitites;
using DatabaseEF.Interfaces;

namespace DatabaseEF.Repositories;

public class UnitOfWork: IUnitOfWork, IDisposable
{
    private Repository<Lead> leadRepository = null;
    private MyDbContext _contexto = null;
    private bool disposed = false;


    // public UnitOfWork()
    // {
    //     _contexto = new MyDbContext();
    // }
    
    public UnitOfWork(MyDbContext context)
    {
        _contexto = context;
    }
    
    public void Commit()
    {
        _contexto.SaveChanges();
    }

    public IRepository<Lead> LeadRepository
    {
        get
        {
            if (leadRepository == null)
            {
                leadRepository = new Repository<Lead>(_contexto);
            }
            return leadRepository;
        }            
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _contexto.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}