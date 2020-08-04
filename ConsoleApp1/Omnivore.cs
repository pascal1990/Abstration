using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Omnivore : Animal
    {
        public override void Boire()
        {
            base.Boire();
            Console.WriteLine($"Je suis Omnivore");
        }

        public override void Manger()
        {
            Console.WriteLine($"Manger des herbes et la viande");
        }
    }
}
