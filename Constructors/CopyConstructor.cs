using System;

namespace Constructors
{
    class CopyConstructor
    {
        string Name;

        public CopyConstructor()
        {
            Name = "Defalut";
        }
        public CopyConstructor(string name)
        {
            Name = name;
        }
        public CopyConstructor(CopyConstructor c)
        {
            Name = c.Name;

        }
        public void Display() => Console.WriteLine($"Name : {Name}");
    }
}
