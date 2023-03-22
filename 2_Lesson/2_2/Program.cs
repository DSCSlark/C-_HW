// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

void NumRendom()

{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num / 100}{num % 10}");
}

NumRendom();

// ----------------------------------------

string SecNum (int num)
{
    return $"{num} -> {num / 100 * 10} + {num % 10}";
}

int val = int.Parse(Console.ReadLine()!);
string result = SecNum(val);
Console.WriteLine(result);