using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective5
{
    public static class Listing_2_63
    {

        public static void RunMain()
        {
           
        }

        class Test
        {
            [Fact]
            [Trait("Category", "Unit Test")]
            public void MyUnitTest()
            { }
            [Fact]
            [Trait("Category", "Integration Test")]
            public void MyIntegrationTest()
            { }
        }

        //XUNIT IS NOT INSTALLED
        class TraitAttribute : Attribute
        {
            public TraitAttribute(string v1, string v2)
            {
            }
        }

        class FactAttribute : Attribute
        {
        }
    }

    
}
