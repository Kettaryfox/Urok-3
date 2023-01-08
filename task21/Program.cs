Console.Clear();
int ax = 0, ay = 0, az = 0, bx = 0, by = 0, bz = 0;
InitCoordinatesbyUser(ref ax, ref ay, ref az, ref bx, ref by, ref bz);
PrintABresult(ax, ay, az, bx, by, bz);

static void InitCoordinatesbyUser(ref int ax, ref int ay, ref int az, ref int bx, ref int by, ref int bz)
{
    try
    {
        Console.Write("Введите x точки A ");
        ax = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите y точки A ");
        ay = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите z точки A ");
        az = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите x точки B ");
        bx = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите y точки B ");
        by = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите z точки B ");
        bz = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода {exc.Message}");
        return;
    }
}
static void PrintABresult(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt((Math.Pow((bx-ax),2))+ (Math.Pow((by-ay),2))+ (Math.Pow((bz-az),2)));
    Console.WriteLine($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz} -> {result})");
}





