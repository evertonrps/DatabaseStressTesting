using System.Linq.Expressions;
using DatabaseEF.Entitites;

namespace DatabaseEF.Interfaces;

//public interface IRepositorio<T> where T : class
public interface IRepository<TEntity> where  TEntity:  Entity<TEntity>
{
    // IEnumerable<T> GetTudo(Expression<Func<T, bool>> predicate = null);
    // T Get(Expression<Func<T, bool>> predicate);
    // void Adicionar(T entity);
    // void Atualizar(T entity);
    // void Deletar(T entity);
    // int Contar();
    IEnumerable<TEntity> GetAll();

    TEntity Add(TEntity obj);

    void AddList(IEnumerable<TEntity> obj);

    // TEntity GetById(int id);
    void Update(TEntity obj);

    void Delete(int id);

    IEnumerable<TEntity> GetByFunc(Expression<Func<TEntity, bool>> predicate);
}