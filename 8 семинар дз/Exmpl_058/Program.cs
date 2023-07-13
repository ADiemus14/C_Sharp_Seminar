/* Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18  */


//Умножение матриц осуществляется путем умножения строки на столбец.
// Находятся произведения первого элемента строки и первого элемента столбца, 
//второго элемента строки и второго элемента столбца и т.д. 
//Затем полученные произведения суммируются. 


Console.Write("Нажмите любую клавишу для запуска создания и расчета произведения двух матриц");
Console.WriteLine();
Console.WriteLine();
Console.ReadKey(); 

Console.WriteLine("Матрица А");
int[,] arrayA = GetArray(2, 2, 0, 10);
PrintArray(arrayA);

Console.WriteLine();
Console.WriteLine("Матрица В");
int[,] arrayB = GetArray(2, 2, 0, 10);
PrintArray(arrayB);

Console.WriteLine();

int[,] productArray = ProductMatrix(arrayA,arrayB);
Console.WriteLine("Произведение  матриц равно:");

Console.WriteLine();
PrintArray(productArray);
Console.WriteLine();

//gроизведение 2 массивов
int[,] ProductMatrix(int[,] array1, int[,] array2){
    int row = 2;
    int col = 2;
    int[,] product = new int[row, col];

 for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                for (int k = 0; k < 2; k++){
                    product[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }

        return product;

}


//получение массива 2мер

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

//Вывод массива

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


// int row = (array1.GetLength(0) >= array2.GetLength(0)) ? array1.GetLength(0) : array2.GetLength(0);
//     int col = (array1.GetLength(1) >= array2.GetLength(1)) ? array1.GetLength(1) : array2.GetLength(1);