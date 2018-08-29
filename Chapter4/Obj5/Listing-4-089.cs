


using System;
using System.Collections.Generic;

namespace Chapter4.Obj5
{
    public static class Listing_4_089
    {
        public static void RunMain()
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");

            Console.WriteLine("Using Stack");
            foreach (string s in myStack)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
        }
    }
}
