using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV24.PMA.CrossCutting.DataClasses
{
    public class ConfigEntry
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
    }
}
