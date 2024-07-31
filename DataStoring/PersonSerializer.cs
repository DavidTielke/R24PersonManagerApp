using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring
{
    public class PersonSerializer : IPersonSerializer
    {
        public string SerializeToCsv(Person person)
        {
            var dataLine = $"{person.Id},{person.Name},{person.Age}";
            return dataLine;
        }
    }
}
