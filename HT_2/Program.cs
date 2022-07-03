int minNumber;
int maxNumber;

Console.WriteLine("Добрый день! Я подскажу какое из чисел большее, а какое меньшее. Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < secondNumber)
    {
    minNumber = firstNumber;
    maxNumber = secondNumber;
    }
    else
    {
    minNumber = secondNumber;
    maxNumber = firstNumber;
    }
Console.WriteLine("Минимальное число: ");
Console.WriteLine(minNumber);
Console.WriteLine("Максимальное число: ");
Console.WriteLine(maxNumber);
