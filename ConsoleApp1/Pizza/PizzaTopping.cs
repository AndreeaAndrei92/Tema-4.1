using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaTopping
    {
        List<string> Name = new List<string>() { "Cheese", "Meat", "Vegetable" };
        float cost;
        public void Print()
        {
            Console.WriteLine($"Name={Name}, cost={cost}");
        }

    }
}
