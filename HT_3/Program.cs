int numberOne;
int numberTwo;
int numberThree;
int max;

Console.WriteLine("Добрый день! Я подскажу вам какое из трех чисел больше. Введите первое число");
numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
numberThree = Convert.ToInt32(Console.ReadLine());

if (numberOne < numberTwo)
    {
        if (numberTwo < numberThree)
        {
        max = numberThree;
        }
        else
        {
        max = numberTwo;
        }
    }
else if (numberOne > numberThree)
    {
    max = numberOne;
    }
    else
    {
    max = numberThree;
    }
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max);
