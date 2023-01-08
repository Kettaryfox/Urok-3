Console.WriteLine("Введите целое число");

int N = int.Parse(Console.ReadLine() ?? "");
int i = 1;
while(i <= N)
{
    double num = Math.Pow (i, 3);
    Console.Write($"{N} -> {num}, ");
    i++;
}