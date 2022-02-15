using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            number1 = 3;

            Console.WriteLine(number1);

            int number3 = number1 + number2;

            Console.WriteLine(number3);
        }
    }
}
