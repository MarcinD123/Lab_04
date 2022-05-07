using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class Files
    {
        private Dictionary<char,int> lettercount = new();
        private IList<File> _files;
        private int _directories = 0;
        private int filescount= 0;
        private long Totalsize = 0;
        private IList<AllFiles> _allFiles;
        
        public StringBuilder stringBuilder = new StringBuilder();
        public Files()
        {
            _files = new List<File>();
            _allFiles = new List<AllFiles>();
        }


        public void Search(string path)
        {                                                                                   //utworzenie objektów  przez skanowanie scieżki
            var files = new DirectoryInfo(path);
            try
            {
                foreach (var file in files.GetFiles())
                {
                    _files.Add(new File(file.Name, file.Length / 1024 ^ 2));
                    //Console.WriteLine(file.Name);
                    filescount++;
                    Totalsize += file.Length;
                }
                foreach (var directory in files.GetDirectories())
                {
                    Search(path + "/" + directory.Name);
                    _directories++;
                }
            }
            catch (Exception)            //wywala przy plikach których nie widać w w explorerze
            {
                
                Console.WriteLine("Acces denied");
                
            }
            

        }
        private void GetAllData()
        {
            var types = _files.GroupBy(x =>
            {
                if (Extensions.fileExtensions.TryGetValue(Path.GetExtension(x.FileName), out string value))                 //jeśli klucz-extension jest w dict fileextension zwraca wartość, inaczej zwraca other
                {
                    return value;
                }
                return "other";

            })
            ;
            
            foreach (var fileType in types)
            {
                var totalSize = fileType.Sum(file => file.FileSize);
                var avgSize = fileType.Average(file => file.FileSize);
                var minSize = fileType.Min(file => file.FileSize);
                var maxSize = fileType.Max(file => file.FileSize);

                _allFiles.Add(new AllFiles(fileType.Key, fileType.Count().ToString(), totalSize.ToString(),
                Math.Ceiling(avgSize).ToString(), minSize.ToString(), maxSize.ToString()));



            }
        }
        public void PrintRes()
        {
            Console.WriteLine("Directories: " +_directories);
            Console.WriteLine("Files: "+filescount +" "+ Totalsize+"MB");
            GetAllData();
            Bytypes();    
            ByExtension();
            CountsByFirstLetter();
            ByName();
            BySize();
        }

        private void Bytypes()
        {
            stringBuilder.AppendLine("By types:");
            stringBuilder.AppendLine("\t\t[count] [total size] [avg size] [min size] [max size]");
            foreach (var type in _allFiles)
            {
                stringBuilder.AppendLine(String.Format("{0,10} {1,10} {2,10} {3,10} {4,10} {5,10}", type.Name, type.Count, type.TotalSize, type.AvgSize, type.MinSize, type.MaxSize));
                //stringBuilder.AppendLine($"\t{type.Name} {type.Count} {type.TotalSize} {type.AvgSize} {type.MinSize} {type.MaxSize}");
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
        }

        private void CountsByFirstLetter()//https://stackoverflow.com/questions/7132738/incrementing-a-numerical-value-in-a-dictionary
        {
            
            int currentcount;
            foreach (var file in _files)
            {
                if (lettercount.ContainsKey(file.FileName[0]))
                {
                    currentcount = lettercount[file.FileName[0]];
                    currentcount++;
                    lettercount[file.FileName[0]] = currentcount;
                    //Console.WriteLine(file.FileName);
                    currentcount = 0;
                }
                else
                {
                    lettercount.Add(file.FileName[0], 1);
                }
                
            }
            stringBuilder.AppendLine("Counts by first leter:");
            foreach (var item in lettercount)
            {
                stringBuilder.Append(item);
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
            Console.WriteLine();
            //Console.WriteLine("Counts by first leter:");

            //foreach (var item in lettercount)
            //{
            //    Console.Write(item.Key+" "); ;
            //}
            //Console.WriteLine();
            //foreach (var item in lettercount)
            //{
            //    Console.Write(item.Value + " "); ;
            //}
            //Console.WriteLine();
            //Console.WriteLine();



        }

        private void BySize()
        {
            var types = _allFiles.OrderBy(x => x.TotalSize);
            stringBuilder.AppendLine("Ordered by sizes (from biggest):");
            stringBuilder.AppendLine("\t\t[count] [total size] [avg size] [min size] [max size]");
            foreach (var type in types)
            {
                stringBuilder.AppendLine(String.Format("{0,10} {1,10} {2,10} {3,10} {4,10} {5,10}", type.Name, type.Count, type.TotalSize, type.AvgSize, type.MinSize, type.MaxSize));
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
        }

        private void ByName()
        {
            var types = _allFiles.OrderBy(x => x.Name);
            stringBuilder.AppendLine("Ordered by name:");
            stringBuilder.AppendLine("\t\t[count] [total size] [avg size] [min size] [max size]");
            foreach (var type in types)
            {
                stringBuilder.AppendLine(String.Format("{0,10} {1,10} {2,10} {3,10} {4,10} {5,10}", type.Name, type.Count, type.TotalSize, type.AvgSize, type.MinSize, type.MaxSize));
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
        }

        private void ByExtension()
        {
            var types = _allFiles.OrderBy(x => x.Count);
            stringBuilder.AppendLine("By extensions:");
            stringBuilder.AppendLine("\t\t[count] [total size] [avg size] [min size] [max size]");
            foreach (var type in types)
            {
                stringBuilder.AppendLine(String.Format("{0,10} {1,10} {2,10} {3,10} {4,10} {5,10}", type.Name, type.Count, type.TotalSize, type.AvgSize, type.MinSize, type.MaxSize));
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
        }

       
    }
}
