using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hotel
    {
        public string Name;
        public string City;
        public List<Room> room = new List<Room>();
        public float GetPriceForNumberOfRooms(int numberOfRooms)
        {
            float pricefordays = room1.GetPriceForDays(2);
            return pricefordays * numberOfRooms;
        }
        public void Print()
        {
            Console.WriteLine($"Name={Name}, City={City}, Rooms=");
            foreach (var elem in room)
            {
                Console.Write(elem);
            }
            Console.WriteLine();
        }

    }
}
