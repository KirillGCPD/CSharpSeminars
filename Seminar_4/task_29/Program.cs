// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Генерация массива из заданного числа элементов с заданным максимальным и минимальным значением
int [] GenerateArray(int arrayLenght,int minValue, int maxValue)
{
    var randomizer=new Random();
    int [] result =new int[arrayLenght];
    for (int i=0;i<arrayLenght;i++)
    {
        result[i]=randomizer.Next(minValue,maxValue);
    }
    return result;
}
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Вывод на экран
void PrintArray(int[] array)
{
    Console.WriteLine("["+string.Join(", ",array)+"]");
}

//Основная часть программы

var arrayLenght=ReadInt("Введите длину массимва: ");
var min=ReadInt("Введите минимальное значение элемента: ");
var max=min;
while (max<=min) //проверка на дурака
{
     max=ReadInt("Введите максимальное значение элемента (но не меньше минимального): ");
}

PrintArray(GenerateArray(arrayLenght,min,max));