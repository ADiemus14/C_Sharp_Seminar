/* Задача 52.
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк) */


 
 
// Метод заполнения двумерного массива  
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++){ 
        for(int j = 0; j < n; j++){ 
            result[i,j] = new Random().Next(minValue, maxValue); 
        } 
    } 
    return result; 
} 
 
// Метод вывода двумерного массива 
void PrintArray(int[,] inArray){ 
    for(int i = 0; i < inArray.GetLength(0); i++){ 
        for(int j = 0; j < inArray.GetLength(1); j++){ 
            Console.Write($"{inArray[i,j]} "); 
        } 
        Console.WriteLine(); 
    } 
}

Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
int[,] newArray = GetArray(rows, columns, 0, 10); 
PrintArray(newArray); 

Console.WriteLine(""); 


for(int j=0; j < columns; j++){
     int sum = 0;
    for(int i=0; i < rows; i++){
               sum += newArray[i,j];
    }
    double arithMean = 0;
    arithMean = Math.Round((double)sum/ (double) rows , 2);
    sum = 0;
    Console.Write($"{arithMean} "); 
}




// for (int j = 0; j < newArray.GetLength(1); j++){
//    for (int i = 0; i < newArray.GetLength(0); i++)
//         sum += newArray[i,j];
// }
// double arithMean = sum/rows;

// Console.Write($"Среднее арифмитическое {arithMean}"); 

