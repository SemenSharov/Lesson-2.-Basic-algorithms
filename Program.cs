// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 99;
int b = 999;
int c = 9999;
int d = 99999;

if ((a < number) && (b > number))
{
    int number1 = number % 100;
    int number2 = number1 % 10;
    Console.WriteLine(number2);
}
if ((b < number) && (c > number))
{
    int number1 = number % 1000;
    int number2 = number1 % 100;
    int number3 = number2 % 10;
    Console.WriteLine(number3);
}

if ((c < number) && (d > number))
{
    int number1 = number / 100 % 10;
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine("Слишком большое число");
}

if (number < a)
{
    Console.WriteLine("Нет третьего числа");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет