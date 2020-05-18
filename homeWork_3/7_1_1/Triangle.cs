using System;

namespace _7_1_1
{
    class Triangle 
    {
        protected double side1;
        protected double side2;
        protected double side3;
    }
    class Triangle1 : Triangle
    {
        private double P;
        public Triangle1(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        //method_1
        public double Perimeter()
        {
            P = side1 + side2 + side3;
            return P;
        }
        public double AreaOfTriangle()
        {
            //heronis formula
            return Math.Sqrt(P * (P - side1) * (P - side2) * (P - side3));
        }

      

    }
}




