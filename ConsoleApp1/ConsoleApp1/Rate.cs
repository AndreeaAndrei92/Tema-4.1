using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rate
    {
        public float Amount;
        public float Currency;
        public void Print()
        {
            Console.WriteLine($"Amount={Amount}, Currenct={Currency}");
        }
    }
}
