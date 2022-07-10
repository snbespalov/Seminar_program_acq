// 14.Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Решение 1
// Console.WriteLine("Введите число");
// int userNum = Convert.ToInt32(Console.ReadLine());
// int res7;
// int res23;

// int result7 (int num1)
// {
//     int num = userNum;
//     if (num % 7 == 0) res7 = 0;
//     else res7 = 1;
//     return res7;
// }
// int result23 (int num2)
// {
//     int num = userNum;
//     if (num % 23 == 0) res23 = 0;
//     else res23 = 2;
//     return res23;
// }
// string res = result7 (userNum) == result23 (userNum) ? "Число кратно 7 и 23" : "Число не кратно 7 и 23";
// Console.WriteLine(res);

// Решение 2

 Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());

if(userNum % 7 == 0 && userNum % 23 == 0)
{
Console.WriteLine("Число кратно 7 и 23");
}
else
Console.WriteLine("Число не кратно 7 и 23");