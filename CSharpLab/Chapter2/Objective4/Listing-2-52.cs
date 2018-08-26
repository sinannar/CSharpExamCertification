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
    public static class Listing_2_52
    {
        public static void RunMain()
        {
            Rectangle rectangle = new Square(1, 1);
            rectangle.Width = 10;
            rectangle.Height = 5;
            Console.WriteLine(rectangle.Area); // Incorrect expected area 

            Console.Write("Press a key to exit");
            Console.ReadKey();
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
