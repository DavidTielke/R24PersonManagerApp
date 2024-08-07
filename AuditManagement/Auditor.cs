using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.DataStoring.Contract;
using RV24.PMA.Logic.Domain.AuditManagement.Contract;

namespace RV24.PMA.Logic.Domain.AuditManagement
{
    public class Auditor : IAuditor
    {
        // Repository injecten

        public void Write(AuditLevels level, string message)
        {
            throw new NotImplementedException();
        }
    }

    public class AuditManager : IAuditManager
    {

        private readonly IRepository<AuditEntry> _repository;

        public AuditManager(IRepository<AuditEntry> repository)
        {
            _repository = repository;
        }

        public IQueryable<AuditEntry> GetAll()
        {
            return _repository.Query();
        }

        public IQueryable<AuditEntry> GetForEntry<TType>(int id)
        {
            // Typ in db hinzufügen
            // Type = DavidTielke.PersonManagerApp.CrossCutting.DataClasses.Person.4711
        }
    }
}
