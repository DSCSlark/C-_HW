// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void ThirdNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("There is no 3rd digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

int val = int.Parse(Console.ReadLine()!);
ThirdNum(val);