// 17.Напишите программу, которая принимает на вход
// координаты точки X и Y, причем X не равно 0 и Y не равно 0,
// и выдает четверть плоскости, в которой находится эта точка

//              Y
//              |             
//              |             
//        2     |       1      
//              |             
// --------------------------- X
//              | 
//        3     |       4                  
//              |             
//              |             

// Решение 1
Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("1 четверть");
// else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
// else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
// else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
// else Console.WriteLine("Введены некорректные координаты");

// Решение 2
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "1 четверть";
    if (xc < 0 && yc > 0) return "2 четверть";
    if (xc < 0 && yc < 0) return "3 четверть";
    if (xc > 0 && yc < 0) return "4 четверть";
    return "Введены некорректные координаты";
}

string result = Quarter(x,y);
Console.WriteLine(result);
