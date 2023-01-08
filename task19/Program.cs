Console.WriteLine("Введите пятизначное число");

int number = int.Parse(Console.ReadLine() ?? "");

if (number > 9999 && number < 100000)
{
    int para1 = number / 10000 ;
    int para2 =(number /1000) %10;
    int num5 = number %10;
    int num4 = (number/10) %10;

    if (para1 == num5 && para2 == num4)
    {
        Console.WriteLine($" {number} -> да");
    }
    else
    {
        Console.WriteLine($" {number} -> нет");
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}

