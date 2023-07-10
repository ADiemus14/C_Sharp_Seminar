/*  Задача 43: 
Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.Write("Введите значение k1: ");
double k2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Точка пересечения двух прямых по заданным координатам = [{String.Join(", ",IntersectionPoint(b1, k1, b2, k2))}]"); 

// метод точки пересечения

double[] IntersectionPoint(double num1, double num2, double num3, double num4){
    double pointX = 0;
    double pointY = 0;
    
    pointX = -(num1 - num3) / (num2 - num4);
    pointY = num2 * pointX  + num1;
  
    double[] ArrayPoint = new double[] {pointX , pointY};
    return ArrayPoint;
}

//   Console.WriteLine($"y = {pointY}");
//   Console.WriteLine($"x = {pointX}");


// Console.WriteLine($"Точка пересечения двух прямых по заданным координатам = {IntersectionPoint(b1, k1, b2,k2)}"); 
// double pointX = -(b1 - b2) / (k1 - k2);
// double pointY = k1 * pointX + b1;


// double[] IntersectionPoint(double b1, double k1, double b2, double k2){
//     double pointX = 0;
//     double pointY = 0;
//     double[] ArrayPoint = new double[] {pointX , pointY};
//     pointX = -(b1 - b2) / (k1 - k2);
//     Console.WriteLine($"x = {pointX}");
//     pointY = k1 * pointX  + b1;
//     Console.WriteLine($"y = {pointY}");
//     return ArrayPoint;
// }