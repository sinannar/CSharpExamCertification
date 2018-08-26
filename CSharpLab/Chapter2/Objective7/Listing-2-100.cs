using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CSharpLab.Chapter2.Objective7
{
    public static class Listing_2_100
    {
        public static void RunMain()
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine("Person: ");
            Console.WriteLine(string.Format("No format: {0}", p.ToString()));
            Console.WriteLine(string.Format("FL format: {0}", p.ToString("FL")));
            Console.WriteLine(string.Format("LF format: {0}", p.ToString("LF")));
            Console.WriteLine(string.Format("FSL format: {0}", p.ToString("FSL")));
            Console.WriteLine(string.Format("LSF format: {0}", p.ToString("LSF")));
        }

        class Person : IFormattable
        {
            public Person(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return this.ToString("G", CultureInfo.CurrentCulture);
            }

            public string ToString(string format)
            {
                return this.ToString(format, CultureInfo.CurrentCulture);
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (string.IsNullOrWhiteSpace(format) || format == "G")
                {
                    format = "FL";
                }

                format = format.Trim().ToUpperInvariant();

                switch (format)
                {
                    case "FL":
                        return this.FirstName + " " + this.LastName;
                    case "LF":
                        return this.LastName + " " + this.FirstName;
                    case "FSL":
                        return this.FirstName + ", " + this.LastName;
                    case "LSF":
                        return this.LastName + ", " + this.FirstName;
                    default:
                        throw new FormatException(string.Format("The '{0}' format string is not supported.", format));
                }
            }
        }
    }
}


