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


        }
    }
}
