// Задача 52.
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateArray(int m, int n, int l, int h)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(l, h);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void ColumnesArithmeticMean (int[,] array)
{
    Console.WriteLine("Средние арифметические значения столбцов массива: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        Console.Write($"[{j+1}] = {sum / array.GetLength(0)}; ");
    }
    
}

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int low = Prompt("Введите нижнюю границу перебора чисел: ");
int high = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("Полученный массив: ");
int[,] specifiedArray = CreateArray(str, col, low, high);
ColumnesArithmeticMean(specifiedArray);
