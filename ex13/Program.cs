/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int th = num;
if (num > 99)
{
    while (th>999)
    {
        th = th / 10;
    }
    th = th % 10;
    Console.WriteLine($"{num} -> {th}");
}
else
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
