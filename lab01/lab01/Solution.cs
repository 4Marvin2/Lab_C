using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab01
{
    class Solution
    {
        static public int Main(string[] args)
        {
            Console.Title = "Попов Михаил ИУ5-35Б";
            double a, b, c, D; int f = 0;
            string a_str, b_str, c_str;
            a_str = Console.ReadLine();
            try
            {
                a = Convert.ToDouble(a_str);
            }
            catch (FormatException)
            {
                f = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error:incorrect value");
                Console.WriteLine("Usage:<double>");
                Console.ResetColor();
                while (f == 1)
                {
                    a_str = Console.ReadLine();
                    f = 0;
                    try
                    {
                        a = Convert.ToDouble(a_str);
                    }
                    catch (FormatException)
                    {
                        f = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error:incorrect value");
                        Console.WriteLine("Usage:<double>");
                        Console.ResetColor();
                    }
                }
            }
            b_str = Console.ReadLine();
            try
            {
                b = Convert.ToDouble(b_str);
            }
            catch (FormatException)
            {
                f = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error:incorrect value");
                Console.WriteLine("Usage:<double>");
                Console.ResetColor();
                while (f == 1)
                {
                    b_str = Console.ReadLine();
                    f = 0;
                    try
                    {
                        b = Convert.ToDouble(b_str);
                    }
                    catch (FormatException)
                    {
                        f = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error:incorrect value");
                        Console.WriteLine("Usage:<double>");
                        Console.ResetColor();
                    }
                }
            }
            c_str = Console.ReadLine();
            try
            {
                c = Convert.ToDouble(c_str);
            }
            catch (FormatException)
            {
                f = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error:incorrect value");
                Console.WriteLine("Usage:<double>");
                Console.ResetColor();
                while (f == 1)
                {
                    c_str = Console.ReadLine();
                    f = 0;
                    try
                    {
                        c = Convert.ToDouble(c_str);
                    }
                    catch (FormatException)
                    {
                        f = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error:incorrect value");
                        Console.WriteLine("Usage:<double>");
                        Console.ResetColor();
                    }
                }
            }
            a = Convert.ToDouble(a_str);
            b = Convert.ToDouble(b_str);
            c = Convert.ToDouble(c_str);
            if ((a == 0) && (b == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();
                Console.Read();
                Environment.Exit(0);
            }
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
                else if (y2 == 0) x.Add(0);
            }
            for (int i = 0; i < x.Count; i++)
            {
                string s = "x" + Convert.ToString(i + 1) + " = " + Convert.ToString(x[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            }
            Console.Read();

            return 0;
        }
    }
}