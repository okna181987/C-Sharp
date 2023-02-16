//Показать натуральные числа от 1 до N, N задано

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// string NumbersRec(int a, int N)
// {
//     if (a <= N) return $"{a} " + NumbersRec(a + 1, N);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, N));

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}
PrintNumber(20);