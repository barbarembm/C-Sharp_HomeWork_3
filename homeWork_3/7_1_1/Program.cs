using System;

namespace _7_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("side3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());


            Triangle1 tr = new Triangle1(side1, side2, side3);
            double one = tr.Perimeter();
            double two = tr.AreaOfTriangle();


            Console.WriteLine($"Perimeter {one}\n  Area Of Triangle  {two}");
            Console.ReadKey();
        }
    }
}
