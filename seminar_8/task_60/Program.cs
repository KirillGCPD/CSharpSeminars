// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] GenerateRandomArray(int m,int min,int max)
{
    var randomizer=new Random();
    var result = new int[m,m,m];
    for (int i=0;i<m;i++)
    {
        for (int k=0;k<m;k++)
        {
            for (int j=0;j<m;j++)
            {
                result[i,k,j]=randomizer.Next(min,max+1);
            }
        }
    }
    return result;
}

//Вывести массив
void PrintIntArray (int[,,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1);
    int l=array.GetLength(2);
    for (int i=0;i<m;i++)
    {
        for (int k=0;k<n;k++)
        { 
            for (int j=0;j<l;j++)
            {
                if (i!=0||k!=0||j!=0) 
                {
                    Console.WriteLine(); //Новая строка но не перед первой строкой
                }
                Console.Write(array[i,k,j]+$"({i};{k};{j})"+"\t");
            }
        }
    }
}
//Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Основной код. Не совсем понял в задании фразу построчно, а в примере по два элемента. Вывел трехмерный массив последовательно по строчно
var m=ReadInt("Введите размерность трехмерного массива: ");
var array=GenerateRandomArray(m,10,99);//генерация трехмерного кубического массива
Console.WriteLine("Сгенерирован массив: ");
PrintIntArray(array);