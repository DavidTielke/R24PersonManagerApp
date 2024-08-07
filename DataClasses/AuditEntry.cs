using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV24.PMA.CrossCutting.DataClasses
{
    public class AuditEntry : EntityBase
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public AuditLevels Level { get; set; }
    }
}
