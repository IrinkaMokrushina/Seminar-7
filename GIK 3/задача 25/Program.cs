// Напишите цикл, который принимает на вход два числа (А и В)
//и возводит число А в натуральную степень В.

int GetPow(int A, int B)
{
    int pow = 1;
    int i = 0;
   
    while (i < B)
    {
        pow = pow * A;
        i = i + 1;
    }
    return pow;
}
Console.Clear();
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPow(a, b));

