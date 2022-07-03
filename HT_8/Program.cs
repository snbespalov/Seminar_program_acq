int count, x;

Console.WriteLine("Добрый день! Я покажу вам все чётные числа до числа, которое вы введете. Введите число");
count = Convert.ToInt32(Console.ReadLine());

for(x = 0; x<count; x++)
    { 
    if ( x % 2 == 0)
    Console.WriteLine(x);
    }