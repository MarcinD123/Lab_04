using System;
using System.IO;
namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files\dotnet";
            var fil1 = new DirectoryInfo(path);
            Console.WriteLine(fil1.ToString());
            var xd = fil1.EnumerateDirectories();
            var wtf = fil1.GetFiles();
            foreach (var item in wtf)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("reeee");
            foreach (var item in xd)
            {
                Console.WriteLine(item.Name+item.GetFiles().Length);
            }




        }
    }
}
