﻿using System;
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
    public static class Listing_3_22
    {
        public static void RunMain()
        {

        }

        class Set<T>
        {
            private List<T>[] buckets = new List<T>[100];

            private int GetBucket(int hashcode)
            {
                // A Hash code can be negative. To make sure that you end up with a positive
                // value cast the value to an unsigned int. The unchecked block makes sure that
                // you can cast a value larger then int to an int safely.
                unchecked
                {
                    return (int)((uint)hashcode % (uint)buckets.Length);
                }
            }

            private bool Contains(T item, int bucket)
            {
                if (buckets[bucket] != null)
                    foreach (T member in buckets[bucket])
                        if (member.Equals(item))
                            return true;
                return false;
            }

            public void Insert(T item)
            {
                int bucket = GetBucket(item.GetHashCode());

                if (Contains(item, bucket))
                    return;

                if (buckets[bucket] == null)
                    buckets[bucket] = new List<T>();

                buckets[bucket].Add(item);
            }

            public bool Contains(T item)
            {
                return Contains(item, GetBucket(item.GetHashCode()));
            }
        }
    }
}
