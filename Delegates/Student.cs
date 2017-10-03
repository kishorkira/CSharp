using System;

namespace Delegates
{
    class Student
    {
        public void Print1(string x)
        {
            Console.WriteLine(x);
        }
        public void Print2(string x,string y)
        {
            Console.WriteLine($"{x}, {y}");
        }
    }
    public delegate void D1(string x);
    public delegate void D2(string x, string y);

}
