string RangeOfQuarter(int quarter)
{
    if (quarter == 1) return "x (0, +infinity), y (0, +infinity)";
    if (quarter == 2) return "x (-infinity, 0), y (0, +infinity)";
    if (quarter == 3) return "x (-infinity, 0), y (-infinity, 0)";
    if (quarter == 4) return "x (0, +infinity), y (-infinity, 0)";
    return null;
}

Console.Write("Введите номер четверти: ");
int quert = Convert.ToInt32(Console.ReadLine());
string range = RangeOfQuarter(quert) != null
               ? RangeOfQuarter(quert)
               : "такой четверти несуществует ";
Console.WriteLine(range);
