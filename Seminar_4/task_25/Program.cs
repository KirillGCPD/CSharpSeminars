// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Получение дробного числа
double ReadDouble (string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
//Функция возведения в степень
double Power(double number, int power)
{
    double result=1; //для 0 степени
    for (int i=0;i<power;i++)
    {
        result*=number;
    }
    return result;
}

var numberA=ReadDouble("Введите первое число: ");
var pow=ReadInt("Введите степень: ");


Console.WriteLine($"Результат возведения {numberA} в степень {pow} равен: {Power(numberA,pow)}");
