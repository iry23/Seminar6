/// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Enter the number of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

void PositiveNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Input {i + 1} number: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Count(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) 
        count += 1;
    }
    return count;
}

PositiveNumbers(m);

Console.WriteLine($"Number of positive numbers introduced is: {Count(numbers)} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"The straight lines meet at the coordinates ({x};{y})");