Console.WriteLine("Введите координаты x != 0");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y != 0");
int y = Convert.ToInt32(Console.ReadLine());
int quarter = LearnQuarter(x, y);
string result = quarter > 0
                ? $"Указанные координаты соответствуют {quarter} четверти"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int LearnQuarter(int x1,int y1)
{
    if (x1 > 0 && y1 > 0) return 1;
    if (x1 < 0 && y1 > 0) return 2;
    if (x1 < 0 && y1 < 0) return 3;
    if (x1 > 0 && y1 < 0) return 4;
    return 0;
}
