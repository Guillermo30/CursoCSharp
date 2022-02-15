using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburonsin",56),
                new Shark("Jaws", 65)
            };

            IFish[] fishs = new IFish[]
            {
                new Siren(100),
                new Shark("Tiburonsin", 56)
            };


            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fishs);
        }

        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("- Mostramos los animales --");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }
        public static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine("- Mostramos los peces --");
            int i = 0;
            while (i< fishs.Length)
            {
                Console.WriteLine(fishs[i].Swim());
                i++;
            }
        }
    }

    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int Speed)
        {
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"La Sirena Nada a {Speed}km/h";
        }
    }

    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"{Name} Nada {Speed} km/h";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }
}
