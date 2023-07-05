// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
            Console.Write(Math.Round(array[i,k],2)+" ");
        }
    }
}
Console.Write("Введите количество строк: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Генерация массива: ");
PrintArray(GenerateRandomArray(m,n,-10,10));