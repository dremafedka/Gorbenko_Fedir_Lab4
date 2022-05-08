using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
       abstract class Skis : Equipment
       {
        public override string Name => "Skis";
        abstract public string Type { get; }

        public override void GetInfo()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Type: {Type} {Name}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
            Console.WriteLine($"Price: {Price} dollars");
            Console.WriteLine("===================");
            Console.WriteLine();
        }

    }
}
