// Напишите программу которая выводит  от 10 до 99 и показывает наибольшую цифру числа
// 78-8
// 12-2


int r = new Random().Next(10, 100);
int a = r/10;
int b = r % 10;

int max = a;

if(max < b){
    max = b;
}
Console.WriteLine($"Наибольшая цифра числа {r} = {max}");