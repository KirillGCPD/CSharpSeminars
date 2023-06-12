// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите число А = ");
var numberA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
var numberB=Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine($"Число А={numberA} больше числа B={numberB}");
}
else if (numberB>numberA)
{
    Console.WriteLine($"Число B={numberB} больше числа A={numberA}");
}
else
{
    Console.WriteLine($"Число A={numberA} равно число B={numberB}");
}