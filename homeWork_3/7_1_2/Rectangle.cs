using System;


namespace _7_1_2
{
    class Rectangle
    {
        protected double baseOfRectangle;
    }

    class Rectangle1 : Rectangle
    {
        private double heightOfRectangle;
        public Rectangle1(double baseOfRectangle, double heightOfRectangle)
        {
            this.baseOfRectangle = baseOfRectangle;
            this.heightOfRectangle = heightOfRectangle;
        }

        public double AreaOfRectangle()
        {
            return heightOfRectangle * baseOfRectangle;
        }
    }
}
