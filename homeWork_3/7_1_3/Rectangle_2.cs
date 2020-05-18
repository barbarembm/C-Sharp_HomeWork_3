using System;
namespace _7_1_3
{
    class Rectangle_2
    {
        protected double baseOfRectangle;
        public Rectangle_2()
        {
            baseOfRectangle = 10;
      
        }

        public Rectangle_2(double baseOfRectangle)
        {
            this.baseOfRectangle = baseOfRectangle;
        }

        public void  Write(Rectangle_2 Write1)
        {
            Console.WriteLine($" baseOfRectangle {Write1.baseOfRectangle}");
        }
    }

    class Rectangle_2_1 : Rectangle_2
    {

        private double heightOfRectangle;

        public void Write2(Rectangle_2_1 Write3)
        {
            Console.WriteLine($"heightOfRectangle {Write3.heightOfRectangle}");
            double heightOfRectangle = Convert.ToDouble(Console.ReadLine());
        }
        public double AreaOfRectangle()
        {
            return baseOfRectangle * heightOfRectangle;
        }
    }

    }
}
