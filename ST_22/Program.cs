// Задача 22. Напишите программу, которая принимает на ход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Покажу таблицу с квадратами всех чисел до введенного числа");
Console.Write("Введите число: ");

int count = Convert.ToInt32(Console.ReadLine());

int Square(int x)
{
    int sqrtNumber = x * x;
    return sqrtNumber;
}

// while (int i = 1, i <= count, i++)
// {
// Console.WriteLine($"{i} | {Square(i)}");
// }

for (int i = 1; i <= count; i++)
{
Console.WriteLine($"| {i} | {Square(i)}");
}