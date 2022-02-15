using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer(){
                    Name="Corona", Country="México"
                },
                new Beer()
                {
                    Name="Delirium", Country="Bélgica"
                },
                 new Beer()
                {
                    Name="Erdinger", Country="Alemania"
                }
            };
            

            foreach(var beer in beers)
                Console.WriteLine(beer);

            Console.WriteLine("--------------------");

            // select
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };
            foreach(var beer  in beersName)
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");

            Console.WriteLine("--------------------");
            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name
                                };
            foreach(var beer in beersNameReal)
                Console.WriteLine(beer.Name);

            Console.WriteLine("--------------------");

            var beersMéxico = from b in beers
                              where b.Country == "México"
                              || b.Country =="Alemania"
                              select b;
            foreach(var beer in beersMéxico)
                Console.WriteLine(beer);

            Console.WriteLine("--------------------");

            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b;
            foreach(var beer in orderedBeers)
                Console.WriteLine(beer);
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} País: {Country}";
        }
    }
}
