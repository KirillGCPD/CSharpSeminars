// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//Генерировать массив случайных чисел заданой длины
int [] GenerateRandomIntArray(int lenght)
{
    var array = new int[lenght];
    Random randomizer=new Random();//генератор случайных чисел
    for (int i=0;i<lenght;i++)
    {
        array[i]=randomizer.Next(-100,101); // 100-999
    }
    return array;
}
//Сумма элементов на четных индексах
int SumOfElementsOnEvenPositions(int[] intArray)
{
    int lenght = intArray.Length; //на всякий случай сохраню длину массива
    int result=0;
    for (int i=0;i<lenght;i++)
    {
        if (i%2==1)
        {
            result+=intArray[i];
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
var array= GenerateRandomIntArray(5);
Console.Write("Сумма элементов стоящих на четных позициях в массиве: ");
PrintArray(array);
Console.WriteLine("Равна: "+ SumOfElementsOnEvenPositions(array));
