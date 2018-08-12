using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_86
    {
        public static void RunMain()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e)
                => { Console.WriteLine("1 has called"); };
            p.OnChange += (sender, e)
                => { throw new Exception(); };
            p.OnChange += (sender, e)
                => { Console.WriteLine("3 has called"); };

            p.Raise();
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };           

            public void Raise()
            {
                OnChange(this, EventArgs.Empty); // no need for null check thx to '= delegate {};'
            }

            public override string ToString()
            {
                return "Pub";
            }
        }
    }


}
