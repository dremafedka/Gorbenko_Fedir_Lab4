using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write price for Snowboard:");
            int price1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var snowboard = new Snowboard(price1);
            snowboard.GetInfo();

            Console.WriteLine("Write price for Running Skis:");
            int price2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var runningSkis = new RunningSkis(price2);
            runningSkis.GetInfo();

            Console.WriteLine("Write price for Mountain Skis:");
            int price3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var mountainSkis = new MountainSkis(price3);
            mountainSkis.GetInfo();
        }
    }
}
