// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int [,] GenerateRandomArray(int m, int n)
{
    int numberOfElements=m*n;
    var result = new int[m,n];
    var count=1;
    int a=0;
    int b=0;
    //строка
    while (count<=numberOfElements) //Немного не оптимальный вариант за счет этих проверок. Можно оптимизировать количество лишних прогонов в которые ничего не происходит
    {
        
        for (int i=0+a;i<n;i++)
        {
            if (count<=numberOfElements) //Защита от перезаписи когда мы делаем лишний прогон. По хорошему надо просто вовремя остановиться
            {
            result[0+a,i]=count;
            }
            count++;
        }
    //правый
         for (int j=1;j<m-b;j++)
         {
             if (count<=numberOfElements)
            {
             result[j+b,n-1]=count;
            }
             count++;
         }
     //нижний
         for (int i=n-2;i>=a;i--)
         {
             if (count<=numberOfElements)
            {
             result[m-1,i]=count;
            }
             count++;
         }
     //Левый
         for (int j=m-2;j>b;j--)
         {
             if (count<=numberOfElements)
            {
             result[j,0+b]=count;
            }
             count++;
         }
        n--;
        m--;
        a++;
        b++;
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

var m=ReadInt("Введите количество строк матрицы: ");
var n=ReadInt("Введите количество столбцов матрицы: ");
var matrix=GenerateRandomArray(m,n);
Console.WriteLine("Сгенерирована матрица заполненная спирально:");
PrintIntArray(matrix);