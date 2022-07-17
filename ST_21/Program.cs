// Задача 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Clear();
Console.WriteLine("Подскажу расстояние между двумя точками в 2D пространстве");
Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double by = Convert.ToDouble(Console.ReadLine());

// double AB = Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) 
                                // + ((by - ay) * (by - ay))),
                                // 2);

double Square(double x,double y)
{
    double res = (y - x) * (y - x);
    return res;
}

double AB = Math.Round(Math.Sqrt((Square(ax,bx)) + Square(ay,by)),2);
Console.WriteLine($"Расстояние между точками: {AB} ");