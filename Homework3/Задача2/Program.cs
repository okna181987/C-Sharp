//  Подсчитать сумму цифр в числе
Console.WriteLine();
int number = new Random().Next(1, 50000);
int sumDigit = 0;
Console.Write($"Сумма цифр числа {number} равна ");
while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}
Console.WriteLine(sumDigit);
Console.WriteLine();
