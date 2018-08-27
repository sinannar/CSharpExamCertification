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
    public static class Listing_3_21
    {
        public static void RunMain()
        {
            
        }

        class Set<T>
        {
            private List<T> list = new List<T>();
            public void Insert(T item)
            {
                if (!Contains(item))
                    list.Add(item);
            }
            public bool Contains(T item)
            {
                foreach (T member in list)
                    if (member.Equals(item))
                        return true;
                return false;
            }
        }
    }
}
