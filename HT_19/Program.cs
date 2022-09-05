// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Подскажу является ли пятизначное число палиндромом.");
Console.WriteLine("Введите пятизначное число");
int userNum = Convert.ToInt32(Console.ReadLine());

bool isPalindrome(int num){
  if(num < 0) return  false; 
  int reversed = 0;
  int r, original = num;
  while(num != 0) {
        r = num % 10; 
        reversed = reversed * 10 + r; 
        num  /= 10; 
  }
  return (reversed == original);
}
if(isPalindrome(userNum))
{
Console.WriteLine("Палиндром");
}
else Console.WriteLine("Не палиндром");
