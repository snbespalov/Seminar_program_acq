// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Подскажу является ли порядковый номер дня недели выходным.");
Console.WriteLine("Введите цифру от 1 до 7");

int userNum = Convert.ToInt32(Console.ReadLine());
int[] workDays = {1,2,3,4,5};
int[] weekEnd = {6,7};

if (workDays.Contains(userNum)) 
{
    Console.WriteLine("Не является выходным днем");
}
else if (weekEnd.Contains(userNum)) 
{
    Console.WriteLine("Является выходным днем");
}
else Console.WriteLine("В неделе всего 7 дней");