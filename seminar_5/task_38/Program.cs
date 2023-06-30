// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//Генерировать массив случайных чисел заданой длины
double [] GenerateRandomDoubleArray(int lenght)
{
    var array = new double[lenght];
    Random randomizer=new Random();//генератор случайных чисел
    for (int i=0;i<lenght;i++)
    {
        array[i]=Math.Round(randomizer.NextDouble() * 100,2);// 99 и дробной в 2 символа
    }
    return array;
}
//Разница между максимальным и минимальным элементом массива
double DiffrentBetweenMaxAndMin(double[] array)
{
    return MaxElementOfArray(array)-MinElementOfArray(array);
    //return 0;
}
double MaxElementOfArray(double[] array)
{
    double max=array[0];
    for (int i=0;i<array.Length;i++)
    {
        if (max<array[i])
        {
            max=array[i];
        }
    }
    return max;
}
double MinElementOfArray(double[] array)
{
     double min=array[0];
    for (int i=0;i<array.Length;i++)
    {
        if (min>array[i])
        {
            min=array[i];
        }
    }
    return min;
}
//Вывод на экран
void PrintArray(double[] array)
{
    Console.WriteLine("["+string.Join(", ",array)+"]");
}
//+++++ОСНОВНОЙ КОД+++++
var array= GenerateRandomDoubleArray(5);
Console.Write("Разница между MAX и MIN элементами массива: ");
PrintArray(array);
Console.WriteLine("Равна: ");
Console.Write(DiffrentBetweenMaxAndMin(array));