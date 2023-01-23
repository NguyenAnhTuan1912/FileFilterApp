using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFilter.DTO
{
    internal class FileModel
    {
        public string fileName { get; set; }
        public string extension { get; set; }
        public string fullFileName { get; set; }
        public string typeOfFile { get; set; }
        public DateTime dateModified { get; set; }
    }
}
