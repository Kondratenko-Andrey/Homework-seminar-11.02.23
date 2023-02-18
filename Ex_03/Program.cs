// Показать натуральные числа от M до N, N и M заданы

void ShowNum(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        ShowNum(m + 1, n);
    }
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

ShowNum(M, N);