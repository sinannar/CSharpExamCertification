using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_87
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

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"{ex.InnerExceptions.Count}");
            }

        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };           

            public void Raise()
            {
                var exceptions = new List<Exception>();

                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if(exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }

            }

            public override string ToString()
            {
                return "Pub";
            }
        }
    }


}
