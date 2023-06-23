// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// формула для решения  
// Расстояние =sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

int DataA(){
    Console.Write("Введите координату для точки А: ");
    return Convert.ToInt32(Console.ReadLine());
}
int DataB(){
    Console.Write("Введите координату для точки B: ");
    return Convert.ToInt32(Console.ReadLine());
}
double AB  = Math.Sqrt( Math.Pow((DataB()-DataA()), 2) + Math.Pow((DataB()-DataA()), 2) + Math.Pow((DataB() - DataA()), 2) );

Console.WriteLine($"Расстояние между координатами точек А и В в 3D пространстве равно {AB:f2}");

