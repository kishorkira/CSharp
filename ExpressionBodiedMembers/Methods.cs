using System;

namespace ExpressionBodiedMembers
{
    class Methods
    {
        public Methods(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{lname} {fname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
}
