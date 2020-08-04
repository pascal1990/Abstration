using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract  class Animal
    {
        public virtual void Boire()
        {
            Console.WriteLine($"Boire de l'eau");
        }

        public abstract void Manger();
    }
}
