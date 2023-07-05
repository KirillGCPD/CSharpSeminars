// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Преобразовать массив чисел в строку для вывода пользователю
string ArrayToString(double[] array)
{
    return "("+string.Join(",",array)+")";
}
double ReadDouble()
{
    return Convert.ToDouble( Console.ReadLine());
}
// y = k1 * x + b1, y = k2 * x + b2;
double [] FindCrossOfTwoLines(double b1,double k1, double b2, double k2)
{
  var result=new double[2];
    result[0]=(b2-b1)/(k1-k2);
    result[1]=k1*result[0]+b1; //y=k1*x+b1
  return result;
}
Console.WriteLine($"Введите значения коэффциентов уравнения y = k1 * x + b1, y = k2 * x + b2;");
Console.Write("b1 = ");
double b1=ReadDouble();
Console.Write("k1 = ");
double k1=ReadDouble();
Console.Write("b2 = ");
double b2=ReadDouble();
Console.Write("k2 = ");
double k2=ReadDouble();
Console.Write("Точка пересения двух линий равна: ");
Console.WriteLine(ArrayToString(FindCrossOfTwoLines(b1,k1,b2,k2)));
