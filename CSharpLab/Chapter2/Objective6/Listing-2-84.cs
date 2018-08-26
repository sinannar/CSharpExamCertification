using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;


namespace CSharpLab.Chapter2.Objective6
{
    public static class Listing_2_84
    {
        public static void RunMain()
        {
            
        }

        class UnmangedWrapper : IDisposable
        {
            public FileStream Stream { get; private set; }

            public UnmangedWrapper()
            {
                this.Stream = File.Open("temp.dat", FileMode.Create);
            }

            ~UnmangedWrapper()
            {
                Dispose(false);
            }

            public void Close()
            {
                Dispose();
            }

            public void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (Stream != null)
                    {
                        Stream.Close();
                    }
                }
            }

            public void Dispose()
            {
                Dispose(true);
                System.GC.SuppressFinalize(this);
            }
        }
    }
}


