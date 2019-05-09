using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        PizzaBase PizzaBase;
        List<PizzaTopping> Tooping = new List<PizzaTopping>();
        public void AddTopping()
        {

        }
        public void CalculateTotalCost()
        {

        }
        public void Print()
        {
            Console.WriteLine($"PizzaBase={PizzaBase}, PizzaTopping={PizzaTopping}");
        }
    }
}
