// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
//Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Умноежеие двух матриц
int[,] MultiplicateMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int m1=firstMatrix.GetLength(0); //количество строк первой матрицы и будет размерность резульирующей матрицы
    int n1=firstMatrix.GetLength(1);
    int m2=secondMatrix.GetLength(0);   
    int n2=secondMatrix.GetLength(1);
    var result=new int[m1,m1];
    for (int i=0; i<m1;i++) //Для каждой строки
    {
        for (int k=0;k<m1;k++) //для каждой ячейки в результируещем массиве
        {
            for(int j=0;j<n1;j++) //суммируем произведение элементов стобца и строки
            {
                result[k,i]+=firstMatrix[k,j]*secondMatrix[j,i];
            }
        }
    } 
    return result;
}
//---//
Console.WriteLine("Программа генерирует две матрицы, заданных размеров, которые могут быть умножены друг на друга. И производит их умножение");
var m=ReadInt("Введите количество строк первой матрицы: ");
var n=ReadInt("Введите количество столбцов матрицы: ");

var firstMatrix=GenerateRandomArray(m,n,-10,10);
var secondMatrix=GenerateRandomArray(n,m,-10,10); //Будут сгенерированы две матрицы способные умножаться
Console.WriteLine("Сгенерированы две матрицы. Первая: ");
PrintIntArray(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая: ");
PrintIntArray(secondMatrix);
var result=MultiplicateMatrix(firstMatrix,secondMatrix);
Console.WriteLine();
Console.WriteLine("Результат умножения двух матриц: ");
PrintIntArray(result);