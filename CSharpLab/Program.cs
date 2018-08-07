using CSharpLab.Chapter1;
using CSharpLab.Chapter1.Objective1;
using CSharpLab.Chapter1.Objective2;
using CSharpLab.Chapter1.Objective3;
using System;
using System.Threading.Tasks;

namespace CSharpLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RunObjective1.RunMain();
            RunObjective2.RunMain();
            RunObjective3.RunMain();
        }
    }
}
