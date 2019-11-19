using System;
using System.Collections;
using System.Collections.Generic;
using lab02;
using SparseMatrix;


namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(77, 42);
            Quadrate b = new Quadrate(56);
            Circle c = new Circle(24);
            Rectangle d = new Rectangle(5, 3);
            Circle e = new Circle(100);
            Quadrate f = new Quadrate(22);

            ArrayList first_list = new ArrayList() { a, b, c, d, e, f };

            Console.WriteLine("Not sorted ArrayList");

            foreach (GeometricFigure el in first_list)
            {
                Console.WriteLine(Convert.ToString(el.Square()));
            }

            Console.WriteLine("\nSorted List");

            List<GeometricFigure> geometric_figures = new List<GeometricFigure>();
            geometric_figures.Add(new Rectangle(77, 42));
            geometric_figures.Add(new Quadrate(56));
            geometric_figures.Add(new Circle(24));
            geometric_figures.Add(new Rectangle(5, 3));
            geometric_figures.Add(new Circle(100));
            geometric_figures.Add(new Quadrate(22));

            GeometricFigure curr;
            for (int i = 0; i < geometric_figures.Count; i++)
            {
                for (int j = 0; j < geometric_figures.Count - 1; j++)
                {
                    if (geometric_figures[j].CompareTo(geometric_figures[j + 1]) > 0)
                    {
                        curr = geometric_figures[j];
                        geometric_figures[j] = geometric_figures[j + 1];
                        geometric_figures[j + 1] = curr;
                    }
                }
                
            }
            for (int i = 0; i < geometric_figures.Count; i++)
            {
                Console.WriteLine(Convert.ToString(geometric_figures[i].Square()));
            }

            Console.WriteLine("\nExample of matrix");

            Matrix<GeometricFigure> matrix_of_figures = new Matrix<GeometricFigure>(2, 2, 2, f);
            matrix_of_figures[0, 0, 1] = a;
            matrix_of_figures[0, 1, 0] = b;
            matrix_of_figures[0, 0, 0] = c;
            matrix_of_figures[0, 1, 1] = d;
            matrix_of_figures[1, 1, 0] = e;
            Console.WriteLine(matrix_of_figures);

            Console.WriteLine("\nExample of SimpleStack");

            SimpleStack<GeometricFigure> stack_of_figures = new SimpleStack<GeometricFigure>();
            stack_of_figures.Push(a);
            stack_of_figures.Push(b);
            stack_of_figures.Push(c);
            while (stack_of_figures.Count > 0)
            {
                Console.WriteLine(stack_of_figures.Pop());
            }

            Console.ReadKey();
        }
    }
}
