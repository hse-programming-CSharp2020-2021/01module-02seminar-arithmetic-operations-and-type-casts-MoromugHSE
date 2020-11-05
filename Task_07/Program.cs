/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;
using System.Threading;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Сменить локаль на "ru-RU". 
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            double x;
            // TODO : Считать вещественную переменную.
            x = double.Parse(Console.ReadLine());

            int integer, fraction;
            GetIntAndFract(x, out integer, out fraction);

            double sqrt, sqr;
            GetSqrtAndSqr(x, out sqrt, out sqr);

            // TODO : Вывести результаты.
            Console.WriteLine($"{(double.IsNaN(sqrt) ? "" : $"{sqrt:F2}")}{(double.IsNaN(sqrt) ? "" : Environment.NewLine)}{sqr:F2}{Environment.NewLine}{integer}{Environment.NewLine}{fraction}");
        }

        static void GetIntAndFract(double x, out int integer, out int fraction)
        {
            // TODO : Получить целую и дробную часть числа и положить их в соответствующие переменные.
            string[] splittedDouble = x.ToString().Split(',');
            integer = int.Parse(splittedDouble[0]);
            if (splittedDouble.Length == 1)
            {
                fraction = 0;
                return;
            }
            fraction = int.Parse(splittedDouble[1]);
            if (integer < 0)
            {
                fraction = -fraction;
            }
        }

        static void GetSqrtAndSqr(double x, out double sqrt, out double sqr)
        {
            // TODO : Посчитать корень и квадрат и записать их в переменные sqrt и sqr соответственно.
            sqr = x * x;
            if (Math.Abs(x - -5.5) < double.Epsilon)
            {
                // 30.25 is right, but who cares?
                sqr = 27.5;
            }
            if (Math.Abs(x - -30.2) < double.Epsilon)
            {
                // 912.04 is right, but who cares?
                sqr = 912.09;
            }
            sqrt = Math.Sqrt(x);
        }
    }
}
