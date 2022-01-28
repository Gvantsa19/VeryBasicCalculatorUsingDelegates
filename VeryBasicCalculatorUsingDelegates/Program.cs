using System;

namespace VeryBasicCalculatorUsingDelegates
{

    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator.Delegate Add = BasicCalculator.Add;
            BasicCalculator.Delegate Sub = BasicCalculator.Sub;
            BasicCalculator.Delegate Mult = BasicCalculator.Mult;
            BasicCalculator.Delegate Divide = BasicCalculator.Divide;


            Console.WriteLine("enter first Number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second Number");
            int second = int.Parse(Console.ReadLine());

            double result;

            Console.WriteLine("choose option");
            Console.WriteLine("1. add");
            Console.WriteLine("2. sub");
            Console.WriteLine("3. mult");
            Console.WriteLine("4. divide");
            Console.WriteLine("");

            bool run = true;

            do
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        result = Add(first, second);
                        Console.WriteLine("");
                        Console.WriteLine($"{first} + {second} = {result}");
                        break;
                    case 2:
                        result = Sub(first, second);
                        Console.WriteLine("");
                        Console.WriteLine($"{first} - {second} = {result}");
                        break;
                    case 3:
                        result = Mult(first, second);
                        Console.WriteLine("");
                        Console.WriteLine($"{first} * {second} = {result}");
                        break;
                    case 4:
                        result = Divide(first, second);
                        Console.WriteLine("");
                        Console.WriteLine($"{first} / {second} = {result}");
                        break;
                    case 0:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }

            } while (run);

            
        }
    }
}
