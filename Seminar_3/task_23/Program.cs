// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
var number = Convert.ToInt32(Console.ReadLine()); 
if (number<0)
{
    Console.WriteLine("Введите число больше 0");
    return;
}
for (int i=1;i<=number;i++)
{
    if (i==1)
    {
        Console.Write(Math.Pow(i,3));
    }
    else
    {
        Console.Write($", {Math.Pow(i,3)}");
    }
}