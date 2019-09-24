using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            // object rectangle 24x42
            Rectangle a = new Rectangle (24, 42); 
            // object quadrate 56x56
            Quadrate b = new Quadrate (56); 
            // object circle r=77
            Circle c = new Circle(77);

            a.Print();
            Console.WriteLine();

            b.Print();
            Console.WriteLine();

            c.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
