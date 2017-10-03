using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student { FirstName = "kishor", LastName= "kira"};
            var s2 = new Student { FirstName = "kishor", LastName = "kira" };

            Console.WriteLine(s1==s2);
            Console.WriteLine(s1.Equals(s2));

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if(!(obj is Student))
            {
                return false;
            }
            return this.FirstName == ((Student)obj).FirstName &&
                    this.LastName == ((Student)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
