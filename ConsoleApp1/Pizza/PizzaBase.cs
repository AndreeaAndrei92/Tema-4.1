using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaBase
    {
        List<string> Name = new List<string>() { "Regular", "Thick", "Italian" };
        float cost;
        public void Print()
        {
            Console.WriteLine($"Name={Name}, cost={cost}");
        }
    }
}
