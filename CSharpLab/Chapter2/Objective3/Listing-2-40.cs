using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective3
{
    public static class Listing_2_40
    {
        public static void RunMain()
        {

        }

        interface ILeft
        {
            void Move();
        }

        interface IRight
        {
            void Move();
        }

        class MovableObject : ILeft, IRight
        {
            void ILeft.Move() { }

            void IRight.Move() { }
        }
    }
}
