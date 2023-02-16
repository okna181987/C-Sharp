// Найти сумму элементов от M до N, N и M заданы

// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 10));