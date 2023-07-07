// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//Генерация двухмерного массива размерность M*N, случайными вещественным числами в диапазоне от min до max

//Генерация случайного числа в диапазоне
double GenerateDouble(int min, int max)
{
    var randomizer=new Random();
    double result=randomizer.Next(min,max); //генерация целой части
    result+=randomizer.NextDouble(); //добавляю дробную часть
    return result;
}
//Генерация двухмерного массива размерность M*N, случайными вещественным числами в диапазоне от min до max
double [,] GenerateRandomArray(int m, int n,int min,int max)
{
    var result = new double[m,n];
    for (int i=0;i<m;i++)
    {
        for (int k=0;k<n;k++)
        {
            result[i,k]=GenerateDouble(min,max);
        }
    }
    return result;
}
//Вывести массив
void PrintArray (double[,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1);
    for (int i=0;i<m;i++)
    {
       if (i!=0) 
       {
        Console.WriteLine(); //Новая строка но не перед первой строкой
       }
        for (int k=0;k<n;k++)
        {
            Console.Write(Math.Round(array[i,k],1)+"\t");
        }
    }
}
Console.WriteLine("Сгенерирован массив:");
var array=GenerateRandomArray(5,7,-10,10);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите строку (нумерация с 1): ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец (нумерация с 1): ");
int n= Convert.ToInt32(Console.ReadLine());

if (m<1||n<1||m>array.GetLength(0)||n>array.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Элемент в позиции [{m},{n}] равен {Math.Round(array[m-1,n-1],1)}");
}