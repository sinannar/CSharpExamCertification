using System;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_09
    {
        public static void RunMain()
        {
            MyClass instance = new MyClass();
            instance.MyInstanceField = "Some New Value";
            Console.WriteLine(instance.MyInstanceField);
            Console.WriteLine(MyClass.MyStaticField);
            MyClass.MyStaticField = 43;
            Console.WriteLine(MyClass.MyStaticField);
        }

        public class MyClass
        {
            public string MyInstanceField;

            public static int MyStaticField = 42;

            public string Concatenete(string valueToAppend)
            {
                return MyInstanceField + valueToAppend;
            }
        }
    }
}
