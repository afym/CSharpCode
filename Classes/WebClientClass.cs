using System;
using System.Net;

namespace CSharpCode.Classes
{
    class WebClientClass
    {
        public static int GetLengthResponse(string url = "http://www.tecsup.edu.pe/home/")
        {
            WebClient client = new WebClient();

            client.Headers["User-Agent"] =
            "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
            "(compatible; MSIE 6.0; Windows NT 5.1; " +
            ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

            // download data
            byte[] arr = client.DownloadData(url);

            return arr.Length;
        }
    }
}
