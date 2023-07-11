// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
//Отсортировать элементы в каждой строке
void SortElementsInRows(int [,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1);
    for (int i=0;i<m;i++)
    {
        SortElementsInRow(array,i); //Метод сортировки строки
    }
}
//Отсортировать строку row методом пузырька
void SortElementsInRow(int [,] array,int row)
{
    //int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1); //Количество столбцов
    for (int i=0;i<n;i++)
    {
        for (int k=0;k<n-i-1;k++)
        {
            if (array[row,k]<array[row,k+1])
            {
                int temp=array[row,k];
                array[row,k]=array[row,k+1];
                array[row,k+1]=temp;
            }
        }
    }
}
var array=GenerateRandomArray(4,5,-10,10);
Console.WriteLine("Задан массив: ");
PrintIntArray(array);
Console.WriteLine();
Console.WriteLine("Элементы строк массива отсортированы по убыванию:");
SortElementsInRows(array);
PrintIntArray(array);