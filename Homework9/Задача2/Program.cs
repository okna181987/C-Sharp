//Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
PrintNumber(1, 99);