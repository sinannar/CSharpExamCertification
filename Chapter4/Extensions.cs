using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public static class Extensions
    {
        public static string ToSentenceCase(this byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in bytes)
            {
                sb.Append(string.Format("{0}", value.ToString()));
            }

            return sb.ToString();
        }
    }
}
