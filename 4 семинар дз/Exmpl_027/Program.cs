/*Напишите программу, 
которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */


//    int SumN (string N){
//     int sum = 0;
//      for(int index = 0; index < N.Length; index++){   
//         sum = sum+ N[index];
//     }
//     return sum;
//    }

//     Console.Write("Ввведите число: ");
//     string N = Console.ReadLine()!;

//     Console.WriteLine($"Сумма цифр числа {N} равна {SumN(N)}");


   int SumN (string N){
    int sum = 0;
     for(int index = 0; index < N.Length; index++){   
        sum = sum+ Convert.ToInt32(Char.GetNumericValue(N[index]));
    }
    return sum;
   }

    Console.Write("Ввведите число: ");
    string N = Console.ReadLine()!;

    Console.WriteLine($"Сумма цифр числа {N} равна {SumN(N)}");