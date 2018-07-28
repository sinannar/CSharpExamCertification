using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public static class Listing_1_18_AsyncMainSupport
    {
        public static async Task RunMain()
        {
            string result = await DownloadContent();
            Console.WriteLine(result);
        }

        //public static async Task<string> DownloadContent2()
        //{
        //    return await DownloadContent();
        //}

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                Thread.Sleep(1000);
                return await client.GetStringAsync("http://www.microsoft.com");
            }
        }
    }
}
