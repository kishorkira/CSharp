using System;
namespace SampleLibrary
{
    public class Numbers
    {
        public int Square(int a) => a*a;
        public int Cube(int a) => a * Square(a);
        //---1
        public void Arthmetic(int a, int b)
        {

            Console.WriteLine($"Addition {a} + {b} : {a + b}");
            Console.WriteLine($"Substraction {a} - {b} : {a - b}");
            Console.WriteLine($"Multiplication {a} * {b} : {a * b}");
            Console.WriteLine($"Division {a} / {b} : {a / b}");

        }


        //---3
        public void MultiplicationTableOf(int num)
        {
            System.Console.WriteLine($"Multiplication table of {num}");
            for (int i = 1; i < 11; i++)
            {
                System.Console.WriteLine($"---> {num} x {i} : {num * i}");
            }
        }
        //---11
        public int Reverse(int num)
        {

            int reverse = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                reverse = (reverse * 10) + reminder;

                num = num / 10;
            }
            Console.WriteLine(reverse);
            return reverse;
        }
        //----palindrome

        public void Palindrome(int num)
        {
            int reversedNumber = Reverse(num);
            if (num == reversedNumber)
                Console.WriteLine($"{num} is Palindrome");
            else
                Console.WriteLine($"{num} is not Palindrome");


        }
        //---4,20
        public void Fibonacci(int num)
        {
            int num1 = 1, num2 = 1, num3;
            if (num == 1)
                System.Console.Write($"{num1}\n");
            if (num == 2)
                System.Console.Write($"{num1}, {num2}\n");
            if (num > 2)
            {
                System.Console.Write($"{num1}, {num2}, ");
                for (int i = 3; i <= num; i++)
                {
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3;
                    System.Console.Write($"{num3}");
                }
                System.Console.WriteLine();
            }
        }
        //---5,19
        public void FactorialOf(int num)
        {

            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            System.Console.WriteLine($"Factorial of {num} is {result}");
        }
        //----6
        public void Swap(int num1, int num2)
        {

            System.Console.WriteLine($"Numbers before Swapping : num1 = {num1} num2 = {num2}");
            int temp = num1;
            num1 = num2;
            num2 = temp;
            System.Console.WriteLine($"Numbers  After Swapping : num1 = {num1} num2 = {num2}");


        }

        //---8
        public void SimpleInterest(int principle, double rate, int time)
        {
            double simpleInterest = principle * rate * time;
            System.Console.WriteLine($"Simple Interset for Principle = {principle} Rate = {rate}% Time ={time} Months");
            System.Console.WriteLine($"\t SI = {simpleInterest}");
        }
        //---9,10
        public void IsPositiveOrNegative(int num)
        {
            string PositiveOrNegative = num >= 0 ? "positive" : "Negative";
            System.Console.WriteLine($"{num} is {PositiveOrNegative}");
        }
        //---12,14
        public void IsEvenOrOdd(int num)
        {

            string EvenOdd = num % 2 == 0 ? "Even" : "Odd";
            System.Console.WriteLine($"{num} is {EvenOdd}");

        }
        //---13
        public void IsDivisibleBy5(int num)
        {
            string IsDivisibleBy5 = num % 5 == 0 ? "Divisible by 5" : "Not Divisible by 5";
            System.Console.WriteLine($"{num} is {IsDivisibleBy5}");
        }
        //---15
        public void Max(int a, int b)
        {
            if (a != b)
            {
                int max = a > b ? a : b;
                System.Console.WriteLine($"Max Of {a} and {b} : {max}");
            }
            else
            {
                System.Console.WriteLine($"Numbers {a} and {b} are equal");
            }

        }
        public void Min(int a, int b)
        {
            if (a != b)
            {
                int min = a < b ? a : b;
                System.Console.WriteLine($"Min Of {a} and {b} : {min}");
            }
            else
            {
                System.Console.WriteLine($"Numbers {a} and {b} are equal");
            }

        }
        //---16
        public void Max(int num1, int num2, int num3)
        {
            int num4 = num2 > num3 ? num2 : num3;
            int Max = num1 > num4 ? num1 : num4;
            System.Console.WriteLine($"Max of {num1},{num2},{num3} is : {Max}");
        }

        //---17
        public void PrintSum1To10()
        {
            int sum1To10 = 0;
            for (int i = 1; i < 11; i++)
            {
                sum1To10 += i;
            }
            System.Console.WriteLine($"Sum of 1 to 10 : {sum1To10}");
        }
        //---18
        public void PrintProduct1To10()
        {
            int Product1To10 = 1;
            for (int i = 1; i < 11; i++)
            {
                Product1To10 *= i;
            }
            System.Console.WriteLine($"Product of 1 to 10 : {Product1To10}");
        }
        //---Factors --25-31
        public void FactorsOf(int num)
        {
            int i = 2;
            int count = 2;
            int even = num % 2 == 0 ? 1 : 0;
            int odd = num % 2 == 0 ? 1 : 2;
            while (i < num)
            {
                if (num % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        // Console.WriteLine("{0} is the even factor of {1}", i, num);
                        even++;
                    }
                    else
                    {
                        // Console.WriteLine("{0} is the odd factor of {1}", i, num);
                        odd++;
                    }
                    count++;
                }
                i++;
            }
            Console.WriteLine("total number of factors for {0} is {1}", num, count);
            Console.WriteLine("total number of even factors for {0} is {1}", num, even);
            Console.WriteLine("total number of odd factors for {0} is {1}", num, odd);



        }
        public void DivisibleBy5(int num)
        {
            Console.WriteLine("the number 5 divisible from 1 to 100 are: ");
            int i = 1;
            while (i <= 100)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadLine();


        }
        //----39 Armstrong
        public bool IsArmstrong(int num)
        {
            string OriginalNumber = Convert.ToString(num);
            int ConvertedNumber = 0;
            for (int i = 0; i < OriginalNumber.Length; i++)
            {
                int IntOriginalNumber = Convert.ToInt32(OriginalNumber[i].ToString());
                ConvertedNumber += (int)Math.Pow(IntOriginalNumber, OriginalNumber.Length);

            }

            if (num == ConvertedNumber)
                return true;
            return false;
        }
        //---prime
        public void PrintPrimeUpto(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsPrimeNumber(i))
                    System.Console.Write($"{i},");
            }
            System.Console.WriteLine();

        }
        public bool IsPrimeNumber(int num)
        {
            if (num == 1)
                return false;
            if (num == 2 || num == 3)
                return true;
            if (num > 2 && num % 2 == 0)
                return false;

            for (int i = 3; i <= (int)Math.Ceiling(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }

    }
    public delegate int Del(int a);
}
