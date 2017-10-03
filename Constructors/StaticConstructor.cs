using System;

namespace Constructors
{
    class StaticConstructor
    {
        static double Pi;
        int Radius;
        static StaticConstructor()
        {
            Pi = 3.14;

        }
        public StaticConstructor(int r)
        {
            
            Radius = r;
            Console.WriteLine(Radius*Pi);
        }

    }
}
