// Задача 47.
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// Примеры:
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateOutputArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10) + new Random().NextDouble();
            Console.Write($"{Math.Round(array[i,j], 2)} || ");
        }
        Console.WriteLine();
    }
    return array;
}

CreateOutputArray(3,4);