using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CSharpLab;

namespace FullDotnetExamples
{
    public static class Chptr3_Obj2_Listing_24
    {
        public static void RunMain()
        {
            SignAndVerify();
        }

        public static void SignAndVerify()
        {
            string textToSign = "Test paragraph";
            byte[] signature = Sign(textToSign, "cn=Administrator");

            Console.WriteLine(textToSign + " <= cert =>" + signature.ToSentence());
            Console.WriteLine(Verify(textToSign, signature));
        }

        public static byte[] Sign(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var pkey = cert.PrivateKey;
            var csp = (RSACryptoServiceProvider)pkey;
            byte[] hash = HashData(text);
            return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
        }

        private static X509Certificate2 GetCertificate()
        {
            X509Store my = new X509Store(StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);
            var certificate = my.Certificates[0];
            my.Close();
            return certificate;
        }

        public static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PublicKey.Key;
            byte[] hash = HashData(text);
            return csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
        }

        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] data = encoding.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(data);
            return hash;
        }
    }
}