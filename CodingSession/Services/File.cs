using System.Collections.Generic;

namespace CodingSession.Services
{
    /// <summary>
    /// File data.
    /// </summary>
    public class File
    {
        private string Name{ get; set; }

        private List<string> Extensions { get;  }

        public string Extension { get; set; }

        public File(string name)
        {
            this.Name = name;
        }

        public bool HasExtension()
        {
            return !string.IsNullOrEmpty(Extension);
        }

        public void AddExtension(string newExtension)
        {
            Extensions.Add(newExtension);
        }

        public string GetName() => Name;
    }
}