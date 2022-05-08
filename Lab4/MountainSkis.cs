using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class MountainSkis : Skis
    {
        public override string Type => "Mountain";
        public override int MaxSpeed => 250;
        public MountainSkis(int price)
        {
            Price = price;
        }
    }
}
