/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int p;
			// TODO : Реализовать ввод целочисленного значения.
			p = int.Parse(Console.ReadLine());

			// TODO : Посчиать и вывести результат.
			Console.WriteLine(MaxPermutation(p));
		}
		
		static void SwapDigits(ref int a, ref int b)
        {
			a ^= b;
			b ^= a;
			a ^= b;
        }

		static int MaxPermutation(int x) {
			// TODO : Получить цифры числа используя арифметические операции.
			int firstDigit = x/100,
				secondDigit = x/10%10,
				thirdDigit = x%10;
			if (thirdDigit > secondDigit)
            {
				SwapDigits(ref secondDigit, ref thirdDigit);
            }
			if (thirdDigit > firstDigit)
            {
				SwapDigits(ref firstDigit, ref thirdDigit);
            }
			if (secondDigit > firstDigit)
			{
				SwapDigits(ref firstDigit, ref secondDigit);
			}
			// TODO : Собрать новое число и вернуть его. 
			int max = firstDigit * 100 + secondDigit * 10 + thirdDigit;
			return max;
		}
	}
}
