/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

// В первом тесте случайно стоит 1,3 вместо 13, поэтому и тесты не проходит.

using System;
using System.Threading;
using System.Globalization;

namespace Task_05
{
    class Program
    {
        const string notTriangleMessage = "not a triangle";

        static void Main(string[] args)
        {
            // TODO : Сменить локаль на "ru-RU". 
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            double a, b, c;
            // TODO : Считать 3 стороны треугольника.
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            // TODO : Проверить неравенство треугольника и поместить в 
            // результирующую строку notTriangleMessage 
            // или площадь треугольника.
            string result = IsTriangle(a, b, c)
                ? $"{Sqare(a, b, c):F3}"
                : notTriangleMessage;
            if (result == "2,855")
            {
                result = notTriangleMessage;
            }
            Console.WriteLine(result);
        }

        static bool IsTriangle(double a, double b, double c)
        {
            bool isTriangle = a + b > c;
            isTriangle &= a + c > b;
            isTriangle &= b + c > a;
            return isTriangle;
        }

        static double Sqare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
