//Показать кубы чисел, заканчивающихся на четную цифру;
Console.WriteLine();
int N = new Random().Next(1, 10);
Console.WriteLine($"N = {N}");

//Через цикл 

int number = 1;
Console.WriteLine("By While");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.Write(cube + " ");
    number++;
}
Console.WriteLine();

