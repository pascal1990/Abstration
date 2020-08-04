using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Herbivore : Animal
    {
        
        public override void Manger()
        {
            Console.WriteLine($"Manger des herbes");
        }
    }
}
