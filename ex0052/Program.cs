// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите размер двумерного массива (m*n): ");
var (m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Создание двумерного массива...");
Console.WriteLine();
Random rnd = new Random();
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++) 
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();

double tempSum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum = tempSum + array[j, i];
    }
    tempSum = Math.Round((tempSum/n), 2);
    Console.Write($"{tempSum}; ");
    tempSum = 0;
}
Console.ReadKey();