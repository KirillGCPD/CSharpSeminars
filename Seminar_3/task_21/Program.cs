// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координаты первой точки через пробел: ");
int[] pointA= Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
Console.Write("Введите координаты первой точки через пробел: ");
int[] pointB= Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double deltaX=Math.Pow(pointA[0]-pointB[0],2);
double deltaY=Math.Pow(pointA[1]-pointB[1],2);
double deltaZ=Math.Pow(pointA[2]-pointB[2],2);
double result=Math.Sqrt(deltaX+deltaY+deltaZ);

Console.WriteLine("Расстояние между А и B: "+Math.Round(result,2));