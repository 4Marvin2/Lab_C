using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    class Circle : GeometricFigure, IPrint
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public override double Square()
        {
            double temp;
            temp = Math.PI * Radius * Radius;
            return temp;
        }

        public override string ToString()
        {
            string str;
            str = "радиус: " + Convert.ToString(Radius) + ", площадь: " + Convert.ToString(this.Square());
            return str;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
