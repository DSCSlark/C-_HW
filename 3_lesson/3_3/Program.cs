// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов ичсел от 1 до N.

void S(int n)
{
    int a = 1;
    while (a <= n)
    {
        Console.WriteLine(a * a * a);
        a++;
    }
}

Console.WriteLine("Введите число: ");
S(int.Parse(Console.ReadLine()!));