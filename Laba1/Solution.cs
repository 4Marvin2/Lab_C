using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Solution
    {
        static public void Main()
        {
            double a, b, c, D;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();
                Console.Read();
                Environment.Exit(0);
            }
            double y1, y2;
            List<double> x = new List<double>();
            y1 = (-b + Math.Sqrt(D)) / (2 * a);
            y2 = (-b - Math.Sqrt(D)) / (2 * a);
            if (y1 > 0)
            {

                x.Add(Math.Sqrt(y1));
                x.Add(-Math.Sqrt(y1));
            }
            else
                if (y1 == 0) x.Add(0);
            if (y1 != y2)
            {
                if (y2 > 0)
                {
                    x.Add(Math.Sqrt(y2));
                    x.Add(-Math.Sqrt(y2));
                }
                else
                    if (y2 == 0) x.Add(0);
            }
            Console.WriteLine("Попов Михаил Александрович ИУ5-35Б");
            for (int i = 0; i < x.Count; i++)
            {
                string s = "x" + Convert.ToString(i + 1) + " = " + Convert.ToString(x[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            }
            Console.Read();
        }
    }
}
