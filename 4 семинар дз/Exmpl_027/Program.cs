/*Напишите программу, 
которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");


// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number>0)
//     {
//         sum+=number%10;
//         number/=10;
//     }
//     return sum;
// }

//    int SumN (string N){
//     int sum = 0;
//      for(int index = 0; index < N.Length; index++){   
//         sum = sum+ N[index];
//     }
//     return sum;
//    }

    Console.Write("Ввведите число: ");
    string N = Console.ReadLine()!;

    Console.WriteLine($"Сумма цифр числа {N} равна {SumN(N)}");


   int SumN (string N){
    int sum = 0;
     for(int index = 0; index < N.Length; index++){   
        sum = sum+ Convert.ToInt32(Char.GetNumericValue(N[index]));
    }
    return sum;
   }

    Console.Write("Ввведите число: ");
    string num= Console.ReadLine()!;

    Console.WriteLine($"Сумма цифр числа {N} равна {SumN(N)}");