using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class AllFiles
    {
        public string Name { get; }
        public string Count { get; }
        public string TotalSize { get; }
        public string AvgSize { get; }
        public string MinSize { get; }
        public string MaxSize { get; }
        public AllFiles(string name, string count, string totalSize, string avgSize, string minSize, string maxSize)
        {
            Name = name;           //powinno byc extension xD
            Count = count;
            TotalSize = totalSize;
            AvgSize = avgSize;
            MinSize = minSize;
            MaxSize = maxSize;
        }
    }

    
}
