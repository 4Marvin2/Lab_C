using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    class Rectangle : GeometricFigure, IPrint
    {
        public float Width { get; set; }

        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Square()
        {
            double temp;
            temp = Width * Height;
            return temp;
        }

        public override string ToString()
        {
            string str;
            str = "ширина: " + Convert.ToString(Width) + ", высота: " + Convert.ToString(Height) + ", площадь: " + Convert.ToString(this.Square());
            return str;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
