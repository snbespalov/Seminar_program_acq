// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число {rndNum}");

int firstDigit = rndNum / 100;
int secondDigit = rndNum % 10;
Console.WriteLine($"Результат удаления цифры {firstDigit}{secondDigit}");