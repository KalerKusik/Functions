using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

                SayHello(userName, userAge);
        }

        private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Hello {someName}, sugma balls");
            Console.WriteLine($"You were born in {2021 - someNumber}");
        }

    }
}
