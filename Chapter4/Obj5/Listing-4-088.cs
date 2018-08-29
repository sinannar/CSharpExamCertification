


using System;
using System.Collections.Generic;

namespace Chapter4.Obj5
{
    public static class Listing_4_088
    {
        public static void RunMain()
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            Console.WriteLine("Using Queue");
            foreach (string s in myQueue)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
        }
    }
}
