using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Security;
using System.Runtime.InteropServices;

namespace CSharpLab.Chapter3.Objective2
{
    public static class Listing_3_28
    {
        // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
        public static void RunMain()
        {
            using (SecureString ss = new SecureString())
            {
                Console.WriteLine("Please enter password:");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    if (cki.Key != ConsoleKey.Backspace)
                    {
                        ss.AppendChar(cki.KeyChar);
                        Console.Write("*");

                    }
                }

                ss.MakeReadOnly();
                Console.WriteLine();
                ConvertToUnsecureString(ss);
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        private static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine("Password entered: {0}", Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
