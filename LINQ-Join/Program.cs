using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer()
                {
                    Name="Corona", Country="México"
                },
                 new Beer()
                {
                    Name="Delirium", Country="Bélgica"
                },
                 new Beer()
                {
                    Name="Erdinger", Country="Alemania"
                },
                 new Beer()
                {
                    Name="Minerva", Country="México"
                },
            };

            var countries = new List<Country>()
            {
                new Country()
                {
                    Name="México",Continent ="América"
                },
                new Country()
                {
                    Name="Bélgica", Continent="Europa"
                },
                new Country()
                {
                    Name="Alemania", Continent="Europa"
                }
            };

            var beersWithContinent = from beer in beers
                                     join country in countries
                                     on beer.Country equals country.Name
                                     select new
                                     {
                                         Name = beer.Name,
                                         Country = beer.Country,
                                         Continent = country.Continent
                                     };
            foreach (var beer in beersWithContinent)
            {
                Console.WriteLine($"{beer.Name} {beer.Country} {beer.Continent}");
            }
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

    }

    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }


    }
}
