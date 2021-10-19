using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iNsErT first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iNsErT second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose what to do ('+', '-', '*', '/'");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumbers(firstNumber, secondNumber);
                    break;
                case '/':
                    DivideTwoNumbers(firstNumber, secondNumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(firstNumber, secondNumber);
                    break;
                case '-':
                    SubtractTwoNumbers(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("You stupid?");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }

        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }

        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

    }
}
