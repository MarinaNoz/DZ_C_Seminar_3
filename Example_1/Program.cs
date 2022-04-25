// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
string fiveDigit = Console.ReadLine();
int y = fiveDigit.Length;
if (y != 5)
{
   Console.WriteLine("Некорректный ввод, число должно быть пятизначным"); 
   return;
}

if (fiveDigit[0] == fiveDigit[4] && fiveDigit[1] == fiveDigit[3])
{
    Console.WriteLine("Данное число палиндром");
}
else
{
    Console.WriteLine("Данное число не палиндром");
}
