using System;

namespace _7_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("baseOfRectangle: ");
            double baseOfRectangle = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("heightOfRectangle: ");
            //double heightOfRectangle = Convert.ToDouble(Console.ReadLine());

            Rectangle_2_1 br = new Rectangle_2_1(baseOfRectangle, heightOfRectangle);
            double one = br.AreaOfRectangle();
            Console.WriteLine($"Area Of Rectangle {one}");
            Console.ReadKey();
        }
    }
}
