using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Room
    {
        public string Name;
        public float Rate;
        public int Adults;
        public int Children;
        public float GetPriceForDays(int numberOfDays)
        {
            return Rate * numberOfDays;
        }
        public void Print()
        {
            Console.WriteLine($"Name={Name}, Rate={Rate}, Adults={Adults}, Children={Children}");

        }
    }
}
