Console.WriteLine("Добрый день! Я подскажу является ли ваше число четным. Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0 )
    {
    Console.WriteLine("Чётное");
    }
else
    {
    Console.WriteLine("Нечётное");
    }