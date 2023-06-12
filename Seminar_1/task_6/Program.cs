// See https://aka.ms/new-console-template for more information
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число = ");
var number=Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    System.Console.WriteLine("Да, число четное");
}
else
{
    System.Console.WriteLine("Нет, число не четное");
}  