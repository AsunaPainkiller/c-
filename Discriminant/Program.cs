// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Console.WriteLine("Введите a");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите b");
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите c");
//int c = int.Parse(Console.ReadLine());

//double d=b*b-4*a*c;
//double x1=(-b+Math.Sqrt(d))/(2*a);
//double x2=(-b-Math.Sqrt(d))/(2*a);
//Console.WriteLine($"Корни данного полного квадратного уравнения: {x1} , {x2} ");
using System;
 
namespace QuadraticEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных уравнения - значения a, b и c
            // После ввода данных мы обрезаем лишние пробелы по краям методом Trim()
            // и преобразовываем тип string во float
            Console.Write("Введите значение a = ");
            float a = float.Parse(Console.ReadLine().Trim());
            Console.Write("Введите значение b = ");
            float b = float.Parsegit (Console.ReadLine().Trim());
            Console.Write("Введите значение c = ");
            float c = float.Parse(Console.ReadLine().Trim());
            // Вычисление дискриминанта
            float d = b * b - 4 * a * c;
            // При дискриминанте меньшим 0 - выводим ошибку
            if (d < 0)
            {
                Console.Write("Дискриминант d < 0<!-- hu -->. Решение квадратного уравнения невозможно.");
            }
            else
            {
                // Объявляем корни уравнения
                float x1, x2;
                // При дискриминанте равным 0 оба корня равны
                if (d == 0)
                {
                    x1 = x2 = -(b / 2 * a);
                }
                else
                {
                    // Извлекаем корень из дискриминанта
                    float sqrtD = (float)System.Math.Sqrt(d);
                    // Высчитываем корни уравнения
                    x1 = (-b + sqrtD) / (2 * a);
                    x2 = (-b - sqrtD) / (2 * a);
                }
                // Выводим результат
                Console.Write("d = " + d.ToString() + " x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            }
            // Ждем нажатия клавиши, чтобы завершить выполнение программы
            Console.ReadLine();
        }
    }
}