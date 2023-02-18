// Показать натуральные числа от 1 до N, N задано

void ShowNum(int n)
{
    if (n > 1)
    {
        ShowNum(n - 1);
        Console.Write($"{n} ");
    }

    else Console.Write("1 ");

}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

ShowNum(N);