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
    public static class Listing_2_51
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

        class Square : Rectangle
        {
            public Square(int width, int height)
                : base(width, height)
            { }

            public override int Width
            {
                get
                {
                    return base.Width;
                }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get
                {
                    return base.Height;
                }
                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }
    }
}
