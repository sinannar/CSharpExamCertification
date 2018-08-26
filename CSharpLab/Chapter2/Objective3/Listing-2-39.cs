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
    public static class Listing_2_39
    {
        public static void RunMain()
        {
            var v = new Implementation();
            Implementation v2 = new Implementation();
            IInterfaceA v3 = new Implementation();
            /*
                Severity	Code	Description	Project	File	Line	Suppression State
                Error	CS1061	'Listing_2_39.Implementation' does not contain a definition for 'MyMethod' and no extension method 'MyMethod' accepting a first argument of type 'Listing_2_39.Implementation' could be found (are you missing a using directive or an assembly reference?)	CSharpLab	C:\Users\sinan\source\repos\CSharpExamCertification\CSharpLab\Chapter2\Objective3\Listing-2-39.cs	18	Active
             */
            //v.MyMethod();
            //v2.MyMethod();

            v3.MyMethod();
        }

        interface IInterfaceA
        {
            void MyMethod();
        }

        class Implementation : IInterfaceA
        {
            void IInterfaceA.MyMethod() { }
        }
    }
}
