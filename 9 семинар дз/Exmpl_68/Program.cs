/* Задача 68: 
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
Выполнить с помощью рекурсии. 
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 


определдение функции
A(0,n) = n+1
A(m+1,0) = A(m,1)
A(m+1,n+1) = A(m,A(m+1,n))*/



Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"При m = {m}, n={n} вычисление ф.Аккермана составит A(m,n) = {AckermannFunction(m,n)}");

int AckermannFunction (int a, int b){
    if(a==0) return b+1;
    if(b==0) return AckermannFunction(a-1,1);
    return AckermannFunction(a-1,AckermannFunction(a,b-1));
}


