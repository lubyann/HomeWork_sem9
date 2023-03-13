﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();
Write("Введите numberOne: ");
int numberOne = int.Parse(ReadLine()!);
Write("Введите N: ");
int N = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(numberOne, N));

string PrintNumbers(int start, int end)
{
    if (end == start) return end.ToString();
    return (end + " " + PrintNumbers(start, end - 1));
}
