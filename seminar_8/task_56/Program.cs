// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//Генерация двухмерного массива размерность M*N, случайными числами в диапазоне от min до max
int [,] GenerateRandomArray(int m, int n,int min,int max)
{
    var randomizer=new Random();
    var result = new int[m,n];
    for (int i=0;i<m;i++)
    {
        for (int k=0;k<n;k++)
        {
            result[i,k]=randomizer.Next(min,max+1);
        }
    }
    return result;
}

//Вывести массив
void PrintIntArray (int[,] array)
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
            Console.Write(array[i,k]+"\t");
        }
    }
}
//Возвращает массив сумм элементов массива по строкам (универсально для любой размерности)
int [] SumOfElementsInEachRow(int [,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1);
    var result=new int[m];
    for (int i=0;i<m;i++)
    {
        for (int k=0;k<n;k++)
        {
            result[i]+=array[i,k];
        }
    }
    return result;
}
int IndexOfLowestElement(int [] array)
{
    
}
var array=GenerateRandomArray(5,5,-10,10);
Console.WriteLine("Задан массив: ");
PrintIntArray(array);
Console.WriteLine();
