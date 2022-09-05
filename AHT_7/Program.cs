int number;

Console.WriteLine("Добрый день! Введите трёхзначное число, и я вам назову последнюю цифру");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Последняя цифра: ");
Console.Write(number % 10);

