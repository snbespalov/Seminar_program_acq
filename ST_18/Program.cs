// 18. Напишите программу, которая по заданному номеру чевтерти,
// показывает диапазон возможных координат точек X и Y.

Console.Clear();
Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());


string Coordiantes(int xc)
{
    if (xc == 1) return "X > 0, Y > 0";
    if (xc == 2) return "X < 0, Y > 0";
    if (xc == 3) return "X < 0, Y < 0";
    if (xc == 4) return "X > 0, Y < 0";
    return "Введен некорректный номер";
}

string result = Coordiantes(x);
Console.WriteLine(result);