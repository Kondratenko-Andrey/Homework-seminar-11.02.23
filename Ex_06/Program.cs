// Написать программу вычисления функции Аккермана

int Akk(int n, int m)
{
    if (n == 0) return m+1;
        else if (m==0) return Akk(n-1, 1);
            else return Akk(n-1, Akk(n, m-1));
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

int A = Akk(N,M);

Console.Write(A);
