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
            foreach (var item in xd)
            {
                Console.WriteLine(item.Name+ item.mes);
            }




        }
    }
}
