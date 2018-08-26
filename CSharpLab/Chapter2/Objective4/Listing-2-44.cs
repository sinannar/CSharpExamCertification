using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_44
    {
        public static void RunMain()
        {
            IAnimal animal = new Dog();
            //animal.Bark(); This will thrown an compile error
            (animal as Dog).Bark(); // Is allowed
            animal.Move();
        }

        interface IAnimal
        {
            void Move();
        }

        class Dog : IAnimal
        {
            public void Move() { Console.WriteLine("Move"); }
            public void Bark() { Console.WriteLine("Bark"); }
        }
    }
}
