/* Напишите программу, 
которая задаёт массив из 8 элементов 
и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] getArray(int size)
{
    int[] result = new int[size]; //целочмсленный массив с размером size
for (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(7, 49);
}
return result;
}

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(",",array)}]");