// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
//Преобразовать массив чисел в строку для печати
string ArrayToString(double[] array)
{
    return "("+string.Join(";",array)+")";
}
//Находим среднее арифетческое каждого столбца
double[] AbsOfEachColumn(int[,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1); //Количество столбцов
    var result=new double[n];
    for (int i=0;i<n;i++)
    {
        var sum=0;
        for (int k=0;k<m;k++)
        {
            sum+=array[k,i];
        }
        result[i]=(double)sum/(double)m;
    }
    return result;
}
var array=GenerateRandomArray(4,5,-10,10);
Console.WriteLine("Задан массив: ");
PrintIntArray(array);
Console.WriteLine();
var absArray=AbsOfEachColumn(array);
Console.WriteLine("Среднее арифметическое каждого столбца: "+ArrayToString(absArray));