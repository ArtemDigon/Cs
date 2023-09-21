// int CountDigit(double  digit)
// {
//     int count = 0;
//     if (digit == 0) return 1;
//     while (digit >= 1 ) {
//         digit = digit / 10;
//         Console.WriteLine(digit);
//         count++;
//     }
//     return count;
// }
// double dig = Convert.ToDouble(Console.ReadLine());
// int digCount = CountDigit(dig);
// Console.WriteLine($" -> {digCount}");
// int digit = Convert.ToInt32(Console.ReadLine());
// int result = Fact(digit);
// Console.WriteLine($" -> {result}");

// int Fact(int dig)
// {
//     int fact = 1;
//     for (int i = 1; i <= dig; i++) {
//         fact *= i;
//     }
//     return fact;
// }
void  Pop()
{
    Console.WriteLine("1");
}

void  Pop(string a)
{
    Console.WriteLine(a);
}
 Pop();
 Pop("2");
