using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Schema;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

//Chptr3_Obj2_Listing_19
namespace CSharpLab.Chapter3.Objective2
{
    public static class Listing_3_23
    {
        public static void RunMain()
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            string data = "A paragraph of text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashA: {0}", hashA.ToSentence());

            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashB: {0}", hashB.ToSentence());

            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashC: {0}", hashC.ToSentence());
            Console.WriteLine();
            Console.WriteLine("hashA.SequenceEqual(hashB): {0}", hashA.SequenceEqual(hashB));
            Console.WriteLine("hashA.SequenceEqual(hashC): {0}", hashA.SequenceEqual(hashC));


            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }        
    }    
}
