// Найти сумму элементов от M до N, N и M заданы

int SumNum(int m, int n)
{
    int sum = 0;

    if (m <= n)
    {
        return sum += m + SumNum(m + 1, n);
    }

    else return 0;
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int s = SumNum(M, N);
Console.Write($"Сумма чисел от {M} до {N} равна: {s}");
