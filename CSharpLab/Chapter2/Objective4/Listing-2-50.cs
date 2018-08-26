using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_50
    {
        public static void RunMain()
        {
           
        }

        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                this.Width = width;
                this.Height = height;
            }

            public virtual int Width { get; set; }

            public virtual int Height { get; set; }

            public int Area
            {
                get
                {
                    return Height * Width;
                }
            }
        }

        
    }
}
