using System.IO;

namespace DownLoadAndProcessFilesAndArchives
{
    class Program
    {
        static readonly string[] urls = {
            "https://www.cpr.dk/media/20511/a370712.txt",
            "https://www.cpr.dk/media/20515/vejregister_hele_landet_pr_181001.zip"
        };

        static void Main(string[] args)
        {
            FileHandler.DownloadFiles(urls);
            FileHandler.ProcessDownloadedFiles(Directory.GetCurrentDirectory());
        }
    }
}
