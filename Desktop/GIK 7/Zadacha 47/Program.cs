// Задайте двумерный массив размером m*n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.  0.5 7  -2 -0.2
//1 -3,3 8 -9.9
//8 7 8 -7 1 9

double[,] fillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble()*(n - m) + m;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        array[new Random().Next(0, m), new Random().Next(0, n)] *= -1;
    }
    return array;
}

void PrintBinaryDoubleArray(double[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задать двумерный массив размерм, заполненный случайными вещественными числами");
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

double[,] userArray = fillArray(m, n);
PrintBinaryDoubleArray(userArray);

