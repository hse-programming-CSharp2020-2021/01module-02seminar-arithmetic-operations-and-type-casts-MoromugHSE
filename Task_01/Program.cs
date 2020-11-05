/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using System;
using System.Globalization;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            double x;
            // Ввод данных. 
            x = double.Parse(Console.ReadLine());

            // Вычисление и вывод данных.
            Console.WriteLine($"{Function(x):f2}");

        }

        static double Function(double x)
        {
            double result = 12;
            result = result * x + 9;
            result = result * x - 3;
            result = result * x + 2;
            result = result * x - 4;
            return result;
        }

        static double myPow(double x, int pow)
        {
            if (pow == 0)
            {
                return 1.0;
            }
            if ((pow & 1) == 0)
            {
                return myPow(x * x, pow >> 1);
            }
            return myPow(x, pow - 1) * x;
        }
    }
}
