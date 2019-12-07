using System;
using System.Reflection;

namespace lab06
{

    delegate int PlusOrMinus(int p1, int p2);

    class Program
    {


        static int Plus(int p1, int p2)
        {
            return p1 + p2;
        }
        static int Minus(int p1, int p2)
        {
            return p1 - p2;
        }
        static void PlusOrMinusMethodFunc(string str, int i1, int i2, Func<int, int, int> PlusOrMinusParam)
        {
            int result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + result.ToString());

        }
        static void PlusOrMinusMethod(string str, int i1, int i2, PlusOrMinus PlusOrMinusParam)
        {
            int result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);

            if (isAttribute.Length > 0)
            {
                attribute = isAttribute[0];
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("ДЕЛЕГАТЫ\n");

            int i1 = 10, i2 = 5;
            PlusOrMinusMethod("Плюс ", i1, i2, Plus);
            PlusOrMinusMethod("Минус ", i1, i2, Minus);

            PlusOrMinus useMethod = new PlusOrMinus(Plus);
            PlusOrMinusMethod("Используем метод ", i1, i2, useMethod);


            PlusOrMinus useIdea = Plus;
            PlusOrMinusMethod("Используем \"предположение\" компилятора ", i1, i2, useIdea);

            PlusOrMinus anonMethod = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            PlusOrMinusMethod("Используем анонимный метод ", i1, i2, anonMethod);
            PlusOrMinusMethod("Используем лямбду 0 ", i1, i2,
                (int x, int y) =>
                {
                    int z = x + y;
                    return z;
                });
            PlusOrMinusMethod("Используем лямбду 1 ", i1, i2, (x, y) => { return x + y; });
            PlusOrMinusMethod("Используем лямбду 2 ", i1, i2, (x, y) => x + y);

            Console.WriteLine("\nИспользуем делегат Func<>");

            PlusOrMinusMethodFunc("Используем метод Plus ", i1, i2, Plus);

            string strOutside = "sample text";

            PlusOrMinusMethodFunc("Используем лямбду 0\n", i1, i2,
                (int x, int y) =>
                {
                    Console.WriteLine("\nПеременная вне лямбды " + strOutside);
                    int z = x + y;
                    return z;
                });
            PlusOrMinusMethodFunc("\nИспользуем лямбду 2\n", i1, i2,
                (x, y) =>
                {
                    return x + y;
                });
            PlusOrMinusMethodFunc("\nИспользуем лямбду 3\n", i1, i2, (x, y) => x + y);

            Console.WriteLine("\nИспользуем групповой делегат");
            Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} + {1} = {2}", x, y, x + y); };
            Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} - {1} = {2}", x, y, x - y); };
            Action<int, int> group = a1 + a2;
            group(10, 5);

            Action<int, int> group2 = a1;
            Console.WriteLine("Добавление вызова метода к групповому делегату");
            group2 += a2; group2(10, 5);
            Console.WriteLine("Удаление вызова метода из группового делегата");
            if ((group2 != null) && (a1 != null))
            {
                group2 -= a1;
            }
            group2(20, 10);

            Console.WriteLine("\nРЕФЛЕКСИЯ\n");

            Type t = typeof(ReflectionObserver);

            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПубличные методы");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства с атрубутами");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(CustomAttribute), out attrObj))
                {
                    CustomAttribute attr = attrObj as CustomAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("InvokeMember");
            ReflectionObserver fi = (ReflectionObserver)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            Console.WriteLine("InvokeMethod");
            object[] parameters = { 10, 5 };
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Plus(10,5)={0}", Result);

            Console.ReadLine();
        }
    }
}
