﻿// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Решение 1
Console.WriteLine("Покажу вам вторую цифру трёхзначного числа, которое вы введете.");
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int secondNum = num % 100 / 10;

Console.WriteLine($"Второе число: {secondNum}");



