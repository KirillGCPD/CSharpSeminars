// See https://aka.ms/new-console-template for more information
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число А = ");
var numberA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
var numberB=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C = ");
var numberC=Convert.ToInt32(Console.ReadLine());
var max=numberA;
if (numberB>max)
{  
    max=numberB;
}
if (numberC>max)
{  
    max=numberC;
}
System.Console.WriteLine("Максимальное число из списка: "+max);