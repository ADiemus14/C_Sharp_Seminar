// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// формула для решения  
// Расстояние =sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

Console.Write("Введите координату x точки A : ");
int Ax = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки A : ");
int Ay = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки A : ");
int Az = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B : ");
int Bx = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки B : ");
int By = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки B : ");
int Bz = Convert.ToInt32(Console.ReadLine()!);

double AB  = Math.Sqrt( Math.Pow((Bx-Ax), 2) + Math.Pow((By-Ay), 2) + Math.Pow((Bz - Az), 2) );

Console.WriteLine($"Расстояние между координатами точек А и В в 3D пространстве равно {AB:f2}");

