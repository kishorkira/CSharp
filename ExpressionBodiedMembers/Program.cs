using System;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods p = new Methods("Mandy", "Dejesus");
            Console.WriteLine(p);
            p.DisplayName();

            Console.ReadLine();
        }
    }
}
