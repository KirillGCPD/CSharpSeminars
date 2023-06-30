// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//Генерировать массив случайных трехзанчных чисел заданой длины
int [] GenerateRandom3DigitsIntArray(int lenght)
{
    var array = new int[lenght];
    Random randomizer=new Random();//генератор случайных чисел
    for (int i=0;i<lenght;i++)
    {
        array[i]=randomizer.Next(100,1000); // 100-999
    }
    return array;
}
//Универсальная функция подсчета четных чисел в массиве любой длины и размера
int NumberOfEvenNumber(int[] intArray)
{
    int lenght = intArray.Length; //на всякий случай сохраню длину массива
    int result=0;
    for (int i=0;i<lenght;i++)
    {
        if (intArray[i]%2==0)
        {
            result++;
        }
    }
    return result;
}
//Вывод на экран
void PrintArray(int[] array)
{
    Console.WriteLine("["+string.Join(", ",array)+"]");
}
//+++++ОСНОВНОЙ КОД+++++
var array= GenerateRandom3DigitsIntArray(5);
Console.Write("Количество четных чисел в массиве: ");
PrintArray(array);
Console.WriteLine("Равна: "+ NumberOfEvenNumber(array));
