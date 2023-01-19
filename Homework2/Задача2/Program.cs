// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Ведите число 1: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите число 2: ");
double numberB = Convert.ToDouble(Console.ReadLine());

int numberC = (int)Math.Sqrt(numberA);
            if (numberB * numberB == numberA)
                Console.WriteLine("yes");
            else Console.WriteLine("no");