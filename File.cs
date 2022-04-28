using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class File
    {
        public File(string fileName, decimal fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }
        public string FileName { get;  }
        public decimal FileSize { get;  }
    }
}
