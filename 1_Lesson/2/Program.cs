// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double a = 2;
double b = 33;
double c = 7;

double max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);