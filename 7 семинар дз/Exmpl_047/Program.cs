/* Задача 47. 
Задайте двумерный массив 
размером m×n, 
заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

//заполнение дробными
double [,] GetArray( int m, int n){
    double[,] result = new double [m,n]; // new double[rows, columns];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Math.Round(new Random().NextDouble(),2);
        }
    }
    return result;
} 

//  вывод в консоль
void PrintArray(double[,] newArray){ 
    for(int i = 0; i < newArray.GetLength(0); i++){ 
        for(int j = 0; j < newArray.GetLength(1); j++){ 
            Console.Write($"{newArray[i, j]} ");
        } 
        Console.WriteLine(); 
    } 
}

Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
double[,] DoubleArray = GetArray(rows, columns); 

PrintArray(DoubleArray); 
