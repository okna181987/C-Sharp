//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine();
Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int GetNumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbersComposition(N)}");
Console.WriteLine();