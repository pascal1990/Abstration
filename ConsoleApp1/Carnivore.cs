using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Carnivore : Animal
    {
        public override void Manger()
        {
            Console.WriteLine($"Manger de la viande");
        }
    }
}
