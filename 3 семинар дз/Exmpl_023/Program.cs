/* Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine()!);

for(int num2 = 1; num2 <= num; num2++){
    int cube = Convert.ToInt32(Math.Pow(num2, 3));
Console.WriteLine(cube);
}





Console.Write($"Задайте число: {num} ");