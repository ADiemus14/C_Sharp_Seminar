/* Напишите цикл, который принимает на вход два числа (A и B
) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Degree(int number, int power){
    int product = number; 
    for(int i = 1; i < power; i++){
        product = product*number;
    }
    return product;
}


Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {A} в натуральной степени {B} = {Degree (A, B)}");