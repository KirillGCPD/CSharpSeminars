// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//Получить массив от пользователя
int [] ReadIntArray()
{
   Console.Write("Введите массив целых чисел разделяя их пробелом: ");
        var array = Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
    
    return array;
}
//Преобразовать массив чисел в строку для вывода пользователю
string ArrayToString(int[] array)
{
    return "["+string.Join(", ",array)+"]";
}
int CountNumbersBiggerThenZero(int [] array)
{
    int result=0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i]>0)
        {
            result++;
        }
    }
    return result;
}
var array= ReadIntArray();
var result=CountNumbersBiggerThenZero(array);
Console.WriteLine($"Количество чисел больше 0 в массиве {ArrayToString(array)} равно: {result}");
