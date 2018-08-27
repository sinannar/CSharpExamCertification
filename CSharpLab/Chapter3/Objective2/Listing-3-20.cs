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
    public static class Listing_3_20
    {
        public static void RunMain()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My secret data!");
            Console.WriteLine("Encrypting: {0}", ByteConverter.GetString(dataToEncrypt));
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            Console.WriteLine("Encrypted data: {0}", ByteConverter.GetString(encryptedData));

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine("Decrypted data: {0}", decryptedString);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
