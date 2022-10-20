// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите размер двумерного массива (m*n): ");
var (m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Создание двумерного массива...");
Console.WriteLine();
double[,] array = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++) 
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(Convert.ToDouble(rnd.Next(-9, 10)) + rnd.NextDouble(), 1);
        Console.Write(array[i, j] + "\t ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.ReadKey();