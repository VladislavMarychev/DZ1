﻿//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int NumberN = Convert.ToInt32(Console.ReadLine()!);
 for (int i = 1; i < NumberN; i++)
 {
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        i++;
    }
 }