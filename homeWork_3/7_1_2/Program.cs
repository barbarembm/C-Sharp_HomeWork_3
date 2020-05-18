using System;

namespace _7_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("base of rectangle: ");
            double baseOfRectangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("height of rectangle: ");
            double heightOfRectangle = Convert.ToDouble(Console.ReadLine());

            Rectangle1 kr = new Rectangle1(baseOfRectangle, heightOfRectangle);
            double one = kr.AreaOfRectangle();

            Console.WriteLine($"Area Of Rectangle {one}");
            Console.ReadKey();
        }
    }
}
