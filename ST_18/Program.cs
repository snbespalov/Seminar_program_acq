// 18. Напишите программу, которая по заданному номеру чевтерти,
// показывает диапазон возможных координат точек X и Y.

// Решение 1
Console.Clear();
Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());

// string Coordiantes(int xc)
// {
//     if (xc == 1) return "X > 0, Y > 0";
//     if (xc == 2) return "X < 0, Y > 0";
//     if (xc == 3) return "X < 0, Y < 0";
//     if (xc == 4) return "X > 0, Y < 0";
//     return "Введен некорректный номер";
// }

// string result = Coordiantes(x);
// Console.WriteLine(result);

// Решение 2

switch(x)
{
    case 1: Console.WriteLine("X > 0, Y > 0"); break;
    case 2: Console.WriteLine("X < 0, Y > 0"); break;
    case 3: Console.WriteLine("X < 0, Y < 0"); break;
    case 4: Console.WriteLine("X > 0, Y < 0"); break;
    default: Console.WriteLine("Введен некорректный номер"); break;
}