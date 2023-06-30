/* Задача 34: 
Задайте массив
заполненный случайными положительными трёхзначными числами. 
Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine()!);


int[] Array = new int[size];
Array = GetArray(Array);

int count = 0;

foreach(int el in Array)
{
    count += el %2==0 ? 1 : 0;
}


Console.WriteLine($"Массив по  заданному размеру:[{String.Join(", ", Array)}] , Количество чётных чисел в массиве: {count}]");

