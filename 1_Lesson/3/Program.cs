// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).

Console.WriteLine("Please, write a number");
int n_1 = int.Parse(Console.ReadLine()!);

if (n_1 % 2 == 0)
{
    Console.Write($"The number {n_1} is even");
}
else
{
    Console.Write($"The number {n_1} is odd");
}