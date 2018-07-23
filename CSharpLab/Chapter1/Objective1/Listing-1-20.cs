using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLab.Chapter1.Objective1
{
    public class Listing_1_20
    {
        public static void RunMain()
        {
            Button_Click();
        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        private static async void Button_Click()
        {
            HttpClient httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://microsoft.com")
                .ConfigureAwait(false);
            //Output.Content = content;
        }
    }
}
