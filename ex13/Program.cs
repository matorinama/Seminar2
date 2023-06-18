/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int num3 = num%1000/100;
if (num3 == 0) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(num3);