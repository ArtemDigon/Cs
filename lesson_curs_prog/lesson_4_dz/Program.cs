// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiate(int basse,int indicator)
// {
//     int result = basse;
//     if (basse == 0) return 0;
//     if (indicator == 0) return 1;
//     for (int i = 2; i <= indicator; i++) {
//         Console.WriteLine(i);
//         result *= basse;
//         Console.WriteLine(result);
//     }
//     return result;
// }
// int base2 = Convert.ToInt32(Console.ReadLine());
// int indicator2 = Convert.ToInt32(Console.ReadLine());
// int power = Exponentiate(base2, indicator2);
// Console.WriteLine($"{base2}, {indicator2} -> {power}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// // 9012 -> 12

// void SumOfDigits (int digit)
// {
//     int buf = digit;
//     int sumDigit = 0;
//     while (digit != 0) {
//         sumDigit += digit % 10;
//         digit /= 10;
//     }
//     Console.WriteLine($"{buf} -> {sumDigit}");
// }
// int digit1 = Convert.ToInt32(Console.ReadLine());
// SumOfDigits(digit1);
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
Random random = new Random();
Filling(arr);
Print(arr);
void Filling (int[] array)
{
    for (int i = 0; i < array.Length; i++) {
        array[i] = random.Next(100);
    }
}
void Print (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
            Console.Write($"{array[i]}");
            Console.Write("]");
            return;
        }
        Console.Write($"{array[i]}, ");
    }
}
