//Написать программу масштабирования фигуры.
// Масштабирование равностороннего четырехугольника. (Левый нижний угол (точка А) остается на месте)

int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k)       // пересчитываем координаты (умножаем на коэффициент), кроме координат точки А (левый нижний угол), эта точка не смещается
{
    int[,] coor = new int[4, 2];                                    // для вывода всех координат записываем их в двумерный массив
    for (int ii = 0; ii < 2; ii++)                                  // индекс массива - координаты точки
    {
        for (int j = 0; j < 2; j++)                                 // индекс столбцов, индексы строк задаем ниже вручную,
        {
            if (ii == j)                                            // индекс столбца равен индексу координаты точки
            {
                coor[0, j] = a[ii];                                 // здесь задаем новые координаты с поправкой на неподвижную точку А
                coor[1, j] = (b[ii] - a[ii]) * k + a[ii];
                coor[2, j] = (c[ii] - a[ii]) * k + a[ii];
                coor[3, j] = (d[ii] - a[ii]) * k + a[ii];
            }
        }
    }
    return coor;
}
void PrintCords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}
int k = 2;                                                         
int[] pointA = { 1, 1 };                                            
int[] pointB = { 3, 5 };
int[] pointC = { 9, 5 };
int[] pointD = { 7, 1 };
char[] pointName = { 'A', 'B', 'C', 'D' };

Console.WriteLine();
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCords(newCords, pointName);
