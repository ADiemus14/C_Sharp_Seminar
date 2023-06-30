/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] GetArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

int iSum(int[] ar){
   int sum=0;
    for (int i = 0; i < ar.Length; i++){
    if (i % 2 == 1) 
        sum = sum + ar[i];
        }
        return sum;

}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine()!);


int[] Array = new int[size];
Array = GetArray(Array);


int sumFor_i = iSum(Array);

Console.WriteLine($"Массив по  заданному размеру:[{String.Join(", ", Array)}] , сумма элементов на нечетных индексах составляет: {sumFor_i}");

