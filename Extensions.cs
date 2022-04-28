using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class Extensions
    {
        public static readonly Dictionary<string, string> fileExtensions = new Dictionary<string, string>()
        {
        {".jpg", "images"},
        {".png", "images"},
        {".gif", "images"},
        {".tiff", "images"},
        {".jpeg", "images"},
        {".bmp", "images"},
        {".mp3", "audio"},
        {".ogg", "audio"},
        {".mp4", "video"},
        {".mkv", "video"},
        {".webm", "video"},
        {".txt", "document"},
        {".docx", "document" },
        {".pdf", "document"}
        };

    }
}
