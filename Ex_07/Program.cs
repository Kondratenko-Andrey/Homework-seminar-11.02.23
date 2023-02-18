// Написать программу возведения числа А в целую стень B

int Pow(int a, int b)
{
    if(b == 0) return 1;
        return a * Pow(a, b-1);
}



Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);     

int C = Pow(A,B);

Console.Write($"{A} в степени {B} равно {C}");