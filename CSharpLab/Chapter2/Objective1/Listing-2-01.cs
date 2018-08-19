using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_01
    {
        public static void RunMain()
        {
            Days readingDays = Days.Monday | Days.Saturday | Days.None;
            Console.WriteLine(readingDays); // Monday, Saturday , it does not show None since it is zero... be careful with that
            Console.ReadKey();

            if ((readingDays & Days.None) == Days.None)
                Console.WriteLine(Days.None);
            if ((readingDays & Days.Sunday) == Days.Sunday)
                Console.WriteLine(Days.Sunday);
            if ((readingDays & Days.Monday) == Days.Monday)
                Console.WriteLine(Days.Monday);
            if ((readingDays & Days.Tuesday) == Days.Tuesday)
                Console.WriteLine(Days.Tuesday);
            if ((readingDays & Days.Wednesday) == Days.Wednesday)
                Console.WriteLine(Days.Wednesday);
            if ((readingDays & Days.Thursday) == Days.Thursday)
                Console.WriteLine(Days.Thursday);
            if ((readingDays & Days.Friday) == Days.Friday)
                Console.WriteLine(Days.Friday);
            if ((readingDays & Days.Saturday) == Days.Saturday)
                Console.WriteLine(Days.Saturday);


            Console.ReadKey();
        }
    }

    [Flags]
    public enum Days
    {
        None = 0x0,
        Sunday= 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
    }
}
