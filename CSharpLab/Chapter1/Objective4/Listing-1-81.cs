using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpLab.Chapter1.Objective4
{
    public class Listing_1_81
    {
        public static void RunMain()
        {
            Action<int, int> calcAction = (x, y) =>
            {
                Console.WriteLine("calcAction " + (x + y));
            };

            Func<int, int, int> calcFunc = (x, y) =>
            {
                Console.WriteLine("calcFunc");
                return x + y;
            };

            calcAction(3, 4);
            Console.WriteLine(calcFunc(3, 4));
        }
    }
}
