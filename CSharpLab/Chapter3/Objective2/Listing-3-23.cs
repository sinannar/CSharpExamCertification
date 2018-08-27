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

            Console.WriteLine(hashA.ToSentence());
        }        
    }    
}
