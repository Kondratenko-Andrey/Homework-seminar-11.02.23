// Найти сумму цифр числа

int SumNum(int n)
{
    int sum = 0;

    if (n > 9)
    {
        //Console.WriteLine(n);
        return sum += n % 10 + SumNum(n / 10);
    }

    else
    {
        //Console.WriteLine(n);
        return sum += n;
    }
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int s = SumNum(N);
Console.Write($"Сумма цифр числа {N} равна: {s}");
