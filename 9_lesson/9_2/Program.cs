﻿// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Enter number M: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number N: ");
int num2 = int.Parse(Console.ReadLine()!);

int SumNatural(int M, int N)
{
    if(M > N)
        return 0;
    return N + SumNatural(M, N - 1);
}

int sum = SumNatural(num1, num2);
Console.WriteLine($"Sum of natural numbers is {sum}");