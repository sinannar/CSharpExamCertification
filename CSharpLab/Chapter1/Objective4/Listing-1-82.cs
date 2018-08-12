using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_82
    {
        public static void RunMain()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("event raised by method 1");
            p.OnChange += () => Console.WriteLine("event raised by method 2");
            //p.OnChange = () => Console.WriteLine("event raised by method 3"); //this line would remove all previous subscribers
            //p.OnChange(); // there is nothing prevent calling outsiders to baypass raise method
            p.Raise();
        }
        public class Pub
        {
            public Action OnChange { get; set; }

            public void Raise()
            {
                /*
                if(OnChange != null)
                {
                    OnChange();
                }
                */
                OnChange?.Invoke();
            }
        }
    }

    
}
