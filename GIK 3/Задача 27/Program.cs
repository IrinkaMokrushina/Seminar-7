// Напишите программу, которая принимает на вход число и
//выдает сумму цифр в числе.

int Sum (int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + (n % 10);
        n = n / 10;
    }
    return res;
}
Console. Clear();
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {N} равна {Sum (N)}");