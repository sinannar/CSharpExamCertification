using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_94
    {
        public static void RunMain()
        {
            string pattern = "(Mr\\.?|Mrs\\.?|Miss|Ms\\.?)";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, string.Empty));
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}


