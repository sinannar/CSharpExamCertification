using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_12
    {
        public static void RunMain()
        {
            var v = new ConstructorChaning();
        }

        class ConstructorChaning
        {
            private int p;

            public ConstructorChaning() : this(3) { }

            public ConstructorChaning(int p)
            {
                this.p = p;
            }
        }
    }
}
