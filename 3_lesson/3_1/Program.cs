// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Pal(int num)
{
    int num_1_2 = num / 1000;
    int num_5 = num % 10;
    int num_4 = num / 10 % 10;

    if (num_1_2 == num_5 * 10 + num_4)
        Console.WriteLine($"Yes, {num} is a palindrome");
    else
        Console.WriteLine($"No, {num} is not a palindrome");
}

Console.WriteLine("Enter a five-digit number: ");
int val = int.Parse(Console.ReadLine()!);

Pal(val);