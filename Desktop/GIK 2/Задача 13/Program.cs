// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num <= 99)
Console.WriteLine($"Третьей цифры числа нет");

if (num > 99) 

