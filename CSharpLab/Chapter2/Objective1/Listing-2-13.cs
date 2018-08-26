﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_13
    {
        public static void RunMain()
        {

        }

        struct Nullable<T> where T : struct
        {
            private bool hasValue;
            private T value;

            public Nullable(T value)
            {
                this.hasValue = true;
                this.value = value;
            }

            public bool HasValue { get { return this.hasValue; } }

            public T Value
            {
                get
                {
                    if (!this.HasValue)
                    {
                        throw new ArgumentException();
                    }

                    return this.value;
                }
            }
        }
    }
}
