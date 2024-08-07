using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Logic.Domain.AuditManagement.Contract
{
    public interface IAuditor
    {
        void Write(AuditLevels level, string message);
    }
}
