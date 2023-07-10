/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

//задайте числа для массива
// перевести числа в массив
// найти числа больше нуля
// зачесть в переменную количество
// вывести на экран


// начальный вариант

// Console.Write("Введите числа для подсчёта: ");

// string NewArray = Console.ReadLine()!;


Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine()!);


int[] NewArray = new int[size];
NewArray = GetArray(NewArray);

Console.WriteLine($"Массив [{String.Join(", ",NewArray)}]");

Console.WriteLine($"Количество положительных чисел в массиве = {positiveNum(NewArray)}"); 


//метод поиска положительных

int positiveNum(int[] ar){
        int count = 0;

       foreach(int el in ar){
        count  += el > 0 ? 1:0;
        }
    return count;
}


//метод  рандомного массива по заданным границам
int[] GetArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-27, 10);
    }
    return arr;
}
