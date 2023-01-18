// Показать вторую цифру трёхзначного числа

System.Console.WriteLine();

int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Вторая цифра числа {number} является цифра {number/10%10}");
System.Console.WriteLine();
