using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[8]{
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
                null,
                null
            };

            friends[0] = "Héctor";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);

            friends[7] = "Carlos";

            Console.WriteLine(friends[7]);
        }
    }
}
