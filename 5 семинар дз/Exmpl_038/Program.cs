// /* Задача 38: 
// Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**/

int[] GetArray (int[] arr){
    for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(10,99);
    }
    return arr;
}

int diffNum(int[] ar){
    int min = ar[0];
    int max = ar[0];
   

    foreach(int el in ar){
        min = el < min ?  el:min;
        max = el > max ?  el:max;

    }
    Console.WriteLine($"min = {min} и  max = {max}");
    return max - min;
}




Console.Write("Ведите размер массива:");
int size = int.Parse(Console.ReadLine()!);

int[] Array = new int[size];
Array = GetArray(Array);

Console.WriteLine($"Массив по заданному размеру[{String.Join(", ",Array)}]"); 
Console.WriteLine($"Разница между максимальным и миинимальным значением составляет {diffNum(Array)}");
