using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab.Chapter3.Objective2
{
    public static class Extensions
    {
        public static string ToSentence(this byte[] array)
        {
            string result = string.Empty;
            foreach (var i in array)
            {
                result += i.ToString();
            }

            return result;
        }
    }
}
