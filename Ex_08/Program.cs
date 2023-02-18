// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем


void Fib(int a, int b, int n)
{
    if (n != 0)
    {
        Console.Write($"{a} ");
        Fib(b, b + a, n - 1);

    }
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Fib(A,B,N);