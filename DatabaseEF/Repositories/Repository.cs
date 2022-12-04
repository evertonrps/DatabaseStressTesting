using System.Linq.Expressions;
using DatabaseEF.Context;
using DatabaseEF.Entitites;
using DatabaseEF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseEF.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected MyDbContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(MyDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void AddList(IEnumerable<TEntity> obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByFunc(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }