// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет является ли этот день выходным.

Console.Clear();
Console.Write("Введите число дня недели:");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
 Console.WriteLine("Понедельник - рабочий день");
 }
if (x == 2)
{
    Console.WriteLine("Вторник - рабочий день");
}
if (x == 3)
{
    Console.WriteLine("Среда - рабочий день");
}
if (x == 4)
{
    Console.WriteLine("Четверг - рабочий день");
}
if (x == 5)
{
    Console.WriteLine("Пятница - рабочий день");
}
if (x == 6)
{
    Console.WriteLine("Суббота - выходной");
}
if (x == 7)
{
    Console.WriteLine("Воскресенье - выходной");
}
else if (x > 7)
{
    Console.WriteLine("Не знаю");
}

