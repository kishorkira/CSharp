using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student {
                FirstName="first",
                LastName="last"
            };
            Console.WriteLine(s);
        }
    }

    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} -- {LastName}";
        

    }
}
