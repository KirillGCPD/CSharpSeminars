// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumElementsRecur(int m,int n)
{
    
    if (m==n)
    {
        return m;
    }
    return SumElementsRecur(m+1,n)+m;
}

var m=ReadInt("Введите значение M: ");
var n=ReadInt("Введите значение N: ");
Console.WriteLine($"Сумма натруальных чисел между {m} и {n} равна {SumElementsRecur(m,n)}");