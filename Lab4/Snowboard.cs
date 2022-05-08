using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Snowboard : Equipment
    {
        public override string Name => "Snowboard";
        public override int MaxSpeed => 150;

        public Snowboard(int price)
        {
            Price = price; 
        }

        public override void GetInfo()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
            Console.WriteLine($"Price: {Price} dollars");
            Console.WriteLine("===================");
            Console.WriteLine();
        }
    }
}
