using System;
using System.IO;
using System.Collections.Generic;
namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Podaj Ścieżkę (Dysk:\xxxx\xxxxx)");
            var inp = Console.ReadLine();
            var files = new Files();
            files.Search(inp);
            files.PrintRes();
            //https://dirask.com/posts/WSEI-2021-2022-lato-labN-1-IS-Programowanie-obiektowe-lab-4-studia-niestacjonarne-139v9p
            //https://app.pluralsight.com/course-player?clipId=ce7fb384-dad3-473a-ad75-49b4e4cf2ac0
            //https://app.pluralsight.com/course-player?clipId=7ad2611b-02a5-428f-9409-9da333dfb138


            //string path = @"D:\Dziedzic_Marcin";
            //var fil1 = new DirectoryInfo(path);


            ////counters
            //int filescount = 0;
            //int dircount = 0;
            //long totalsize = 0;

            ////filetypes
            ////List<string> images = new List<string> { ".jpg", ".png", ".bmp" };
            ////List<string> document = new List<string> { ".pdf", ".doc", ".docx", ".xml", ".pdf" };
            ////List<string> otherFiletypes = new List<string> { ".rar" };
            ////var filetypes = new Dictionary<string, List<string>>()
            //// {
            ////     {"Image",images},
            ////     {"Document",document },
            ////     {"Other",otherFiletypes }
            //// };


            //searcher(fil1);

            // void searcher(DirectoryInfo directory)
            //{
            //    try
            //    {
            //        var files = directory.GetFiles();
            //        var folders = directory.GetDirectories();

            //        foreach (var item in files)
            //        {


            //            Console.WriteLine(item.Name+" "+" lenght: "+item.Length+ " bytes."); //item.Extension
            //            Console.WriteLine(item.Extension);

            //            totalsize += item.Length;
            //            filescount++;
            //        }
            //        foreach (var item in folders)
            //        {
            //            Console.WriteLine("REEEEEEE");
            //            Console.WriteLine(item.ToString());
            //            Console.WriteLine("Reeeeeeeeeee");

            //            searcher(item);

            //            dircount++;

            //        }
            //    }
            //      catch(Exception)
            //    {

            //        Console.WriteLine("unhandled excep  tion elo");
            //        Console.WriteLine("unhandled exceptio   n elo");
            //    }


            //}
            //Console.WriteLine(filescount);
            //Console.WriteLine(dircount);
            //Console.WriteLine(totalsize);
            //Console.WriteLine("size in MB="+totalsize/ 1048576);

            ////var xdd = fil1.EnumerateDirectories();
            ////var wtf = fil1.GetFiles();                  //zwraca listę plików
            ////int count = 0;
            ////foreach (var item in wtf)
            ////{
            ////    Console.WriteLine(item.Name);
            ////    Console.WriteLine("reeee");
            ////}
            ////foreach (var item in xdd)
            ////{
            ////    Console.WriteLine(item.FullName);
            ////    count++;
            ////}
            ////Console.WriteLine(count);
            ////Console.WriteLine("reeee");
            ////foreach (var item in xd)
            ////{
            ////    Console.WriteLine(item.Name+item.GetFiles().Length);
            ////}




        }
    }
}
