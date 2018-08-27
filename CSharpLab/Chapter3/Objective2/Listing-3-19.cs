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
    public static class Listing_3_19
    {
        public static void RunMain()
        {
            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //string publicKeyXML = rsa.ToXmlString(false);
            //string privateKeyXML = rsa.ToXmlString(true);

            //UnicodeEncoding ByteConverter = new UnicodeEncoding();
            //byte[] dataToEncrypt = ByteConverter.GetBytes("My secret data!");
            //Console.WriteLine("Encrypting: {0}", ByteConverter.GetString(dataToEncrypt));

            //byte[] encryptedData;
            //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            //{
            //    RSA.FromXmlString(publicKeyXML);
            //    encryptedData = RSA.Encrypt(dataToEncrypt, false);
            //}

            //Console.WriteLine("Encrypted data: {0}", ByteConverter.GetString(encryptedData));

            //byte[] decryptedData;
            //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            //{
            //    RSA.FromXmlString(privateKeyXML);
            //    decryptedData = RSA.Decrypt(encryptedData, false);
            //}

            //string decryptedString = ByteConverter.GetString(decryptedData);
            //Console.WriteLine("Decrypted data: {0}", decryptedString);

            //Console.WriteLine("Press a key to exit");
            //Console.ReadKey();
        }
    }
}
