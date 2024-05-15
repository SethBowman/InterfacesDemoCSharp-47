using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_47
{
    public class Dog : IAnimal, IDog
    {
        public int Age { get; set; }
        public string Diet { get; set; }
        public string Owner { get; set; }
        public string Breed { get; set; }

        public void Breathe()
        {
            Console.WriteLine("Dog breathes with it's tongue out!");
        }

        public void Move()
        {
            Console.WriteLine("Dog runs!");
        }
    }
}
