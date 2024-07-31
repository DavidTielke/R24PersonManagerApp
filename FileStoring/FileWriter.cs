using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV24.PMA.Data.FileStoring
{
    public class FileWriter
    {
        public void AppendLine(string path, string line)
        {
            File.AppendAllText(path, "\n" + line);
        }
    }
}
