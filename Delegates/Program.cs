using SampleLibrary;
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new Numbers();
            Del d = new Del(n.Cube);
            d += n.Square;
            
            Console.WriteLine(d(4));
            
        }
    }
}
