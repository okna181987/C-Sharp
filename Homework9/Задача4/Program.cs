// Написать программу вычисления функции Аккермана
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Ack(int m, int n)
{
    if (m > 6 || n > 6 || m < 0 || n < 0) return -1;

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine(Ack(2, 3));
