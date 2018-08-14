using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CSharpLab.Chapter1.Objective5
{
    public static class Listing_1_97
    {
        public static void RunMain()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string context = OpenAndParse("");
                Console.WriteLine($"Parsed : {context}");
            }
            catch (Exception ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }

        }

        private static void Log(Exception ex)
        {
            Console.WriteLine($"Messate : {ex.Message}");
            Console.WriteLine($"StackTrace : {ex.StackTrace}");
            Console.WriteLine($"HelpLink : {ex.HelpLink}");
            Console.WriteLine($"InnerException : {ex.InnerException}");
            Console.WriteLine($"TargetSite : {ex.TargetSite}");
            Console.WriteLine($"Source : {ex.Source}");
        }

        private static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("fileName", "fileName is required");
            }
            return File.ReadAllText(fileName);
        }
    }
}
