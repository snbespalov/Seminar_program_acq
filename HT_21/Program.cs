// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Подскажу расстояние между двумя точками в 3D пространстве");
Console.WriteLine("Введите координаты первой точки");
Console.Write("Точка A координата X: ");
double ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A координата Y: ");
double ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A координата Z: ");
double az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("Точка B координата X: ");
double bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата Y: ");
double by = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата Z: ");
double bz = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((az - bz),2));
Console.WriteLine($"Расстояние от точки до точки:{Math.Round(AB,2)}");
