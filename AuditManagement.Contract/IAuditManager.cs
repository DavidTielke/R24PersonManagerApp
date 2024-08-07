using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Logic.Domain.AuditManagement.Contract
{
    public interface IAuditManager
    {
        IQueryable<AuditEntry> GetAll();
        IQueryable<AuditEntry> GetForEntry<TType>(int id);
    }
}
