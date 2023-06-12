// See https://aka.ms/new-console-template for more information
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число = ");
var number=Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i+=2)
{
    if (i!=2)
    {
        System.Console.Write(", ");
    }
    System.Console.Write(i);
}
if (number<2)
{
    System.Console.WriteLine("N меньше двух, а значит вывода нет");
}