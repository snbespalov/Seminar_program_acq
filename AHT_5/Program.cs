int count, x;

Console.WriteLine("День добрый! Я покажу вам все целые числа в промежутке от -N до N, где N - ваше число.");
Console.WriteLine("Введите число");
count = Convert.ToInt32(Console.ReadLine());

for(x = -count; x <= count; x++)
{
    if(x % 1 == 0)
    Console.WriteLine(x);
}