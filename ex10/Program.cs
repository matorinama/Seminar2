﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {num/10%10}");