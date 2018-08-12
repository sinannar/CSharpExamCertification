using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_84
    {
        public static void RunMain()
        {
            Pub p = new Pub();
            
            p.OnChange += (sender, e) => Console.WriteLine($"event raised with value of {e.Value} from {sender.ToString()}");

            p.Raise();
        }

        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, new MyArgs(42)); // no need for null check thx to '= delegate {};'
            }

            public override string ToString()
            {
                return "Pub";
            }
        }
    }


}
