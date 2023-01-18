

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 
// // ____________method__________
// int degree (int num1, int num2)
// {
//     int result = num1;
//     int count = 2;
//     while (count <= num2)
//     {
//         result = result * num1;
//         count++;
//     }
//     if(num2 == 0)
//             {
//                 result = 1;
//             }
//     return result;
// }
// // _________________________________

// System.Console.Write("Enter the number  ");
// int digit = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the number of degree  ");
// int deg = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {digit} в степени {deg} = {degree(digit, deg)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение 1 - математическое
// Method---------

// int getsum(int number)
// {
//     int sum = 0;
//     int remain = 0;
//     while(number > 0)
//     {
//         remain = number % 10;
//         number = number / 10;
//         sum = sum + remain;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе {Number} равна {getsum(Number)}");

//  Решение 2: через строку.

// Method string
int AllSum (string number)
{
    int sum = 0;
    int i = 0;
    while(i < number.Length)
    {
        sum = sum + Convert.ToInt32(number[i]);
    }
    return sum;
}
Console.Write("Введите число: ");
string Number = Console.ReadLine()!;
Console.WriteLine($"Сумма цифр в числе {Number} равна {AllSum(Number)}");

