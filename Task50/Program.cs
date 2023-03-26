// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void CountPosition (int[,] array, int position)
{
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (position == count)
            position = array[i,j];
            else count++;
        }
    }
    Console.WriteLine($"Значение элемента на заданной позиции = {position}");
}



int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int l = Prompt("Введите нижнюю границу перебора чисел: ");
int h = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("Полученный массив: ");
int[,] array = CreateArray(m, n, l, h);

int p = Prompt("Задайте позицию числа: ");

if (p > m * n || p < 1)
Console.WriteLine("Такого числа в массиве нет!");
else CountPosition (array, p);