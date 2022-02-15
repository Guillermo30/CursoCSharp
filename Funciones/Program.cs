using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Show();

            Sum(1,2);
            Sum(3, 4);

            int m = Mul(5,5);
            Console.WriteLine(m);
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Sum(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        static void Show()
        {
            Console.WriteLine("Hola, soy un texto que se imprime desde función");
        }
    }
}
