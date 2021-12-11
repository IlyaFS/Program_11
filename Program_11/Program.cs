using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти решения уравнения 0=k*x+b");
            Console.WriteLine();
            Console.Write("Введите действиетльное число k: ");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Введите действиетльное число b: ");
            double b = double.Parse(Console.ReadLine());

            Lab11 lab = new Lab11 (k, b);
            Console.WriteLine();
            lab.Root();
            Console.ReadKey();
        }
        struct Lab11
        {
            public double K { get; set; }
            public double B { get; set; }
            public Lab11 (double k, double b)
            {
                K = k;
                B = b;
            }
            public void Root()
            {
                if (K == 0 && B == 0)
                    Console.WriteLine("Уравнение бесконечно");
                else if (K == 0)
                    Console.WriteLine("Уравнение не имеет решения");
                else
                {
                    double x = -B / K;
                    Console.WriteLine("Ответ x= {0}", x);
                }
            }
        }
    }
}
// Разработать структуру для решения линейного уравнения O=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
// Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.


