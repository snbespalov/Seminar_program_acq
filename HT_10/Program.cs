// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Решение 1
Console.WriteLine("Покажу вам вторую цифру трёхзначного числа, которое вы введете.");
Console.WriteLine("Введите трёхзначное число");
string num1 = Console.ReadLine();
char[] countNum;

countNum = num1.ToCharArray(0,2);

Console.WriteLine($"Второе число: {countNum.GetValue(1)}");



