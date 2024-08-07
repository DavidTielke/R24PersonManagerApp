using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring.Contract;

public interface IRepository<TEntity>
    where TEntity : class
{
    IQueryable<TEntity> Query();
    void Insert(TEntity entity);
    void Update(TEntity entity);
}