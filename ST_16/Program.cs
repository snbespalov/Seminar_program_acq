﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 * num2 == num1) Console.WriteLine($"Первое число {num1} является квадратом второго числа {num2}");
else if (num1 * num1 == num2) Console.WriteLine($"Второе число {num2} является квадратом первого числа {num1}");
else Console.WriteLine("Ни одно из чисел не является квадратом другого.");