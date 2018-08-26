using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

/*
    In this case, the implementing class adds an extra set accessor. 
    The advantage of using this
    pattern is that if a user accesses your class through its interface, 
    it will see only the get accessor.
    Direct users of the class will see both the get and the set accessor.  
*/

namespace CSharpLab.Chapter2.Objective4
{
    public static class Listing_2_42
    {
        public static void RunMain()
        {

        }

        interface IReadOnlyInterface
        {
            int Value { get; }
        }

        struct ReadAndWriteImplementation : IReadOnlyInterface
        {
            public int Value { get; set; }
        }
    }
}
