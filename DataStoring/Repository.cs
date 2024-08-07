using Microsoft.EntityFrameworkCore;
using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.DataStoring.Contract;
using RV24.PMA.Data.FileStoring;
using RV24.PMA.Data.FileStoring.Contract;

namespace RV24.PMA.Data.DataStoring;

public class Repository<TEntity> : IRepository<TEntity> 
    where TEntity : class
{
    private readonly DatabaseContext _context;

    public Repository(DatabaseContext context)
    {
        _context = context;
    }

    public IQueryable<TEntity> Query()
    {
        return _context.Set<TEntity>();
    }

    public void Insert(TEntity entity)
    {
        if (entity is ITechnicalData techEntity)
        {
            techEntity.CreatedAt = DateTime.Now;
            techEntity.CreatedBy = "David";
        }

        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
    }
}