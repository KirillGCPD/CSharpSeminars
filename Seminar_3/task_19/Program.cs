// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
var number = Convert.ToInt32(Console.ReadLine()); //Конвертирую в число, чтоб убедиться, что это число
if (number<10000||number>99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}
string str=number.ToString(); 
if (str[0]==str[4]&&str[1]==str[3])
{
    Console.WriteLine("Да, это палиндромом");
}
else
{
    Console.WriteLine("Нет, это не палиндромом");
}