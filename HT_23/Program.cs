// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Покажу таблицу с кубами всех чисел до введенного числа");
Console.Write("Введите число: ");

int count = Convert.ToInt32(Console.ReadLine());

double Cube(int x)
{
    double cubeNumber = Math.Pow(x,3);
    return cubeNumber;
}

for (int i = 1; i <= count; i++)
{
Console.WriteLine($"| {i} | {Cube(i)}");
}