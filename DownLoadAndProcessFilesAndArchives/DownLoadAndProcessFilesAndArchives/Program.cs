using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadAndProcessFilesAndArchives
{
    class Program
    {
        static readonly string[] urls = { "https://www.cpr.dk/media/20511/a370712.txt" };

        static void Main(string[] args)
        {
            FileHandler.DownloadFiles(urls);
        }
    }
}
