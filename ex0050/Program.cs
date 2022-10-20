// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.Write("Введите искомое число в массиве: ");
int searchNum = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == searchNum) 
        {
            count++;
        }
    }
}
if (count == 0) Console.WriteLine("Такого числа в массиве нет!");
else 
{
    Console.WriteLine("Искомое число найдено!");
    Console.WriteLine($"Число {searchNum} найдено {count} раз!");
}
Console.WriteLine();
Console.ReadKey();