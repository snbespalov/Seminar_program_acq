// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Покажу вам третью цифру числа, которое вы введете.");
Console.WriteLine("Введите число");
string num1 = Console.ReadLine();
char[] countNum;

countNum = num1.ToCharArray();

if (countNum.Length >= 3 )
{
    Console.WriteLine($"Третья цифра: {countNum.GetValue(2)}");
}
else Console.WriteLine("В значении меньше 3 цифр.");
