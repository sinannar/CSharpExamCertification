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
    public static class Listing_2_47
    {
        public static void RunMain()
        {
            var v = new Derived();
            v.CallExecute();
        }

        class Base
        {
            protected virtual void Execute() { }
        }

        class Derived : Base
        {
            protected override void Execute()
            {
                this.Log("Before executing");
                base.Execute();
                this.Log("After executing");
            }

            public void CallExecute()
            {
                Execute();
            }

            private void Log(string message) { Console.WriteLine(message); }
        }
    }
}
