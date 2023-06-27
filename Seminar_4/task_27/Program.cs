// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Функция возвращает сумму цифр заданного числа
int SumOfDigits(int inputNumber)
{
    int sum=0;
    while (inputNumber>0)
    {
        sum+=inputNumber%10; //добавлеям остаток от деления
        inputNumber/=10; //отрезаем последний знак
    }
    return sum;
}
var input=ReadInt("Введите число сумму цифр, которого вы хотите посчитать: ");

Console.WriteLine($"Сумма цифр числа {input} равна {SumOfDigits(input)}");
