// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//Генерировать массив случайных чисел заданой длины
double [] GenerateRandomDoubleArray(int lenght)
{
    var array = new double[lenght];
    Random randomizer=new Random();//генератор случайных чисел
    for (int i=0;i<lenght;i++)
    {
        array[i]=Math.Round(randomizer.NextDouble() * 1000,2);// До 10
    }
    return array;
}
//Сумма элементов на четных индексах
// int SumOfElementsOnEvenPositions(int[] intArray)
// {
//     int lenght = intArray.Length; //на всякий случай сохраню длину массива
//     int result=0;
//     for (int i=0;i<lenght;i++)
//     {
//         if (i%2==1)
//         {
//             result+=intArray[i];
//         }
//     }
//     return result;
// }
//Вывод на экран
void PrintArray(double[] array)
{
    Console.WriteLine("["+string.Join(", ",array)+"]");
}
//+++++ОСНОВНОЙ КОД+++++
var array= GenerateRandomDoubleArray(5);
Console.Write("Сумма элементов стоящих на четных позициях в массиве: ");
PrintArray(array);