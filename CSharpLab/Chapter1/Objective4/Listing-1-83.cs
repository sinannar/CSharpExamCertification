using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_83
    {
        public static void RunMain()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("event raised by method 1");
            p.OnChange += () => Console.WriteLine("event raised by method 2");
            //p.OnChange = () => Console.WriteLine("event raised by method 2"); //using event prevent this
            //p.OnChange();                                                     //using event prevent this
            p.Raise();
        }

        public class Pub
        {
            public event Action OnChange = delegate { };

            public void Raise()
            {
                OnChange(); // no need for null check thx to '= delegate {};'
            }
        }
    }


}
