//25 вариант средний уровень
double y = 0;
Console.WriteLine("|    x   |   y    |");
for (double x = -0.5; x <= 4.5; x += 0.2)
{
    if (x < 0)
    {
        y = Math.Exp(-Math.Cos(2 * x) + 1);
    }
    else if ((0 <= x) && (x <= 3))
    {
        y = Math.Sqrt(2 + Math.Cos(x - 1));
    }
    else if (x > 3.5)
    {
        y = 2 * Math.Pow(x, 3);
    }
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");

}