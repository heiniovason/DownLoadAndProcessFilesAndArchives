using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadAndProcessFilesAndArchives
{
    static class FileHandler
    {
        public static void DownloadFiles(string[] urls)
        {
            if (urls.Length > 0)
            {
                foreach (string url in urls)
                {
                    using (var client = new WebClient())
                    {
                        try
                        {
                            Console.WriteLine(string.Format("Connecting to: {0}", url));
                            string fileName = url.Substring(url.LastIndexOf('/') + 1);
                            client.DownloadFile(url, fileName);
                            Console.WriteLine(string.Format("DONE! {0} was sucesfully downloaded.", fileName));
                        }
                        catch (Exception ex)
                        {
                            string errorMessage = string.Format("Connection failed to {0}:\n{1}", url, ex);
                            Console.WriteLine(errorMessage);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("WARNING: insufficient URL string array length.");
            }
        }
    }
}
