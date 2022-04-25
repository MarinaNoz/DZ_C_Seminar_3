// Напишите программу, которая принмиает на вход число (N) и выдает таблицу кубов от 1 до N.

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <=numberN)
{
    Console.Write(i * i * i + ", ");
    i++;
}
