// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.WriteLine("Enter number M: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number N: ");
int num2 = int.Parse(Console.ReadLine()!);

void NaturalArr(int M, int N)
{
    if(M > N)
    return;
    if(N % 2 == 0)
    {
        NaturalArr(M, N - 2);
        Console.Write($"{N} ");
    }
    
}

NaturalArr(num1, num2);


