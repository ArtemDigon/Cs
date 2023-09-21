// double Distance (int x2, int y2, int x3, int y3)
// {
//     return Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
// }
// Console.WriteLine("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x,y,x1,y1);
// Console.WriteLine($"{Math.Round(distance,2, MidpointRounding.ToZero)}");
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// TableSquare(n);
// void TableSquare (int n)
// {
//     for (int i = 1; i < n; i++)
//     {
//         Console.WriteLine($"{i,2} --> {i*i,5}");
//     }
// }

// static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//      for (int i = 1;i < N;i++)
//      {
//         Console.WriteLine(i*i*i);
//      }

//     }
// ShowCube(5);
// static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//       return Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));

//     }
// double result = Length(new int[]{1, 2, 3}, new int[]{4, 5, 6});
// Console.WriteLine(result);
bool abc(int number)
{
if((number > 9999) && (number <= 99999))
{
    if ((number / 10000) == (number % 10))
    {
        if((number / 1000 % 10) == (number % 100 / 10))
        {
           return true;
        }
        else
        {
          return false;
        }
    }
    else
    {
        return false;
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
   return false;
}
}
int num = 645464;
bool a = abc(num);
Console.WriteLine(a);

