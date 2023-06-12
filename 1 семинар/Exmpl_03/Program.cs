//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//3 -> Среда
//5 ->  Пятница

Console.Write("Введите номер загаданного дня недели: ");
int Date = int.Parse(Console.ReadLine()!);

if(Date == 1)
{
    Console.WriteLine("Сегодня ПОНЕДЕЛЬНИК");
}

if(Date == 2)
{
    Console.WriteLine("Сегодня ВТОРНИК");
}

if(Date == 3)
{
    Console.WriteLine("Сегодня СРЕДА");
}

if(Date == 4)
{
    Console.WriteLine("Сегодня ЧЕТВЕРГ");
}

if(Date == 5)
{
    Console.WriteLine("Сегодня ПЯТНИЦА УРА");
}

if(Date == 6)
{
    Console.WriteLine("Сегодня СУББОТА");
}

if(Date == 7)
{
    Console.WriteLine("Сегодня ВОСКРЕСЕНЬЕ, печаль");
}

if(Date < 1)
{
    Console.WriteLine("Такого дня не бывает");
}
if(Date > 7)
{
    Console.WriteLine("Такого дня не бывает");
}