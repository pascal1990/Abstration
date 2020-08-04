using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Animal> na = new List<Animal>()
            {
                new Carnivore(),
                new Herbivore(),
                new Omnivore()
            };

            foreach (Animal elt in na)
            {
                elt.Boire();
                elt.Manger();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
