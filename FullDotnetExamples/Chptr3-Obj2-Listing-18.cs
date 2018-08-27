using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace FullDotnetExamples
{
    public static class Chptr3_Obj2_Listing_18
    {
        public static void RunMain()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var s = rsa.ToString();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine("publicKeyXML:");
            Console.WriteLine(publicKeyXML);
            Console.WriteLine();
            Console.WriteLine("privateKeyXML:");
            Console.WriteLine(privateKeyXML);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}