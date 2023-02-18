// Показать натуральные числа от N до 1, N задано

void ShowNum(int n)
{
    if (n != 0)
    {
        Console.Write($"{n} ");
        ShowNum(n - 1);
    }
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

ShowNum(N);