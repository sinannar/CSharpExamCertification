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

namespace CSharpLab.Chapter3.Objective2
{
    public static class Listing_3_17
    {
        public static void RunMain()
        {
            EncryptDecryptSomeText();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

        }

        public static void EncryptDecryptSomeText()
        {
            string original = "My secret data!";

            Console.WriteLine(string.Format("Encripting: {0}", original));
            using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
            {
                byte[] encrypted = Encrypt(symmetricAlgorithm, original);
                string roundTrip = Decrypt(symmetricAlgorithm, encrypted);
                Console.WriteLine(string.Format("Encrypted result: {0}", encrypted.ToSentence()));
                Console.WriteLine(string.Format("Dencrypted result: {0}", roundTrip));
            }
        }

        private static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform ictE =  aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream csE = new CryptoStream(ms,ictE, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(csE))
                    {
                        sw.Write(plainText);
                    }
                    return ms.ToArray();
                }
            }
        }

        private static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform ictD = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream ms = new MemoryStream(cipherText))
            {
                using (CryptoStream csE = new CryptoStream(ms, ictD, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(csE))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }

    }
}
