using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingSession.Services
{
    /// <summary>
    /// File reading capabilities.
    /// </summary>
    public class FileReader
    {
        private File _file;

        public FileReader(File file)
        {
            _file = file;
        }

        public string Read() => _file.GetName();
    }
}