// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AccermanFunc(int m,int n)
{
    
    if (m==0)
    {
        return n+1;
    }
    if (m>0 &&n==0)
    {
        return AccermanFunc(m-1,1);
    }
    if (m>0&&n>0)
    {
        return AccermanFunc(m-1,AccermanFunc(m,n-1));
    }
    return 0;
}

var m=ReadInt("Введите значение M: ");
var n=ReadInt("Введите значение N: ");
Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равно {AccermanFunc(m,n)}");