/**Задача 42:** Напишите программу, 
которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10   */

Console.Write("Введите десятичное число: ");
int dec = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{dec} в двоичной сс {String.Join(", ", getDec(dec))} ");

// // Метод перевода
// int[] getDec(int dec)
// {
//     int[] Array = new int[16];
//     for(int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = dec % 2;
//         dec = dec / 2; 
//     }
//     Console.WriteLine($"[{String.Join(", ", Array)}]");
//     ReverseArray1(Array);
//     Console.WriteLine($"[{String.Join(", ", Array)}]");
//     return Array;
// }


// // Первый вариант разворота массива
// void ReverseArray1(int[] inArray){
//     for(int i = 0; i < inArray.Length / 2; i++){
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

Console.Write("Введите десятичное число: ");
int dec = int.Parse(Console.ReadLine()!);

string res1 = Convert.ToString(dec, 2);

Console.WriteLine($"{dec} -> {res1}");



