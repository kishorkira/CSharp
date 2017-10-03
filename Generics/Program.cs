using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           string AreEqual = GenericMethods.AreEqual<int>(10,20)?"Equal":"Not Equal";
           string AreEqual2 = GenericClass<string>.AreEqual("Asd", "Asd") ? "Equal" : "Not Equal";

            Console.WriteLine(AreEqual2);
            Console.WriteLine(AreEqual);
            Console.ReadLine();
        }
    }
}
