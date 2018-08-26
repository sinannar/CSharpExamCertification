using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_26
    {
        public static void RunMain()
        {
            int value = Convert.ToInt32("42");
            Console.WriteLine("value = {0}", value);

            value = int.Parse("42");
            Console.WriteLine("value = {0}", value);

            bool success = int.TryParse("42", out value);
            Console.WriteLine("value = {0}", success);

            MyClass myClass = new MyClass(1, "First item");
            Console.WriteLine("myClass = {0}", myClass);

            var input = "2 Second item";
            var myClass2 = MyClass.Parse(input);
            Console.WriteLine("myClass2 = {0}", myClass2);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class MyClass : IFormattable
        {
            public MyClass(int id, string text)
            {
                this.Id = id;
                this.Text = text;
            }

            public int Id { get; set; }

            public string Text { get; set; }

            public static MyClass Parse(string value)
            {
                var splitIndex = value.IndexOf(' ');
                var id = int.Parse(value.Substring(0, splitIndex));
                splitIndex++;
                var text = value.Substring(splitIndex, value.Length - splitIndex);
                var result = new MyClass(id, text);

                return result;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                var result = string.Format("ID: {0} with Text: {1}", this.Id.ToString(), this.Text);
                return result;
            }
        }
    }
}
