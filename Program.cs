

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 
// ____________method__________
int degree (int num1, int num2)
{
    int result = num1;
    int count = 2;
    while (count <= num2)
    {
        result = result * num1;
        count++;
    }
    if(num2 == 0)
            {
                result = 1;
            }
    return result;
}
// _________________________________

System.Console.Write("Enter the number  ");
int digit = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of degree  ");
int deg = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {digit} в степени {deg} = {degree(digit, deg)}");