using System;

namespace Constructors
{
    class PrivateConstructor
    {
        private PrivateConstructor() { }
        public static void A() => Console.WriteLine("A");
        public static void B() => Console.WriteLine("B");
        public static void C() => Console.WriteLine("c");

    }
}
