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
            double k = double.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Lab11 lab = new Lab11();

            lab.O = k * x + b;

            lab.Root();

            Console.ReadKey();
        }
        struct Lab11
        {
            public double O;
            public void Root()
            {
                Console.WriteLine(O);
            }
        }
    }
}
// Разработать структуру для решения линейного уравнения O=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
// Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.


