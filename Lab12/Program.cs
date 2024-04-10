using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");
            double r = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Введите координаты точки");
            double px = Convert.ToDouble(Console.ReadLine());
            double py = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Длина окружности равна {Okr.GetLength(r)}\nПлощаль окружности равна {Okr.GetSquare(r)}");
            if (Okr.Point(px, py, r))
                Console.WriteLine("Точка лежит внутри окружности");
            else
                Console.WriteLine("Точка не лежит внутри окружности");
            Console.ReadKey();
        }
    }
    
}
