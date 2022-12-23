// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


double MiddleArifmetical(int[,] matrix, int rows, int columns)
{
    double sum = 0;
    double a = 0;
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum = sum + matrix[i,j];
            a = sum/rows;
        }
        Console.WriteLine($"{sum},  ");
        Console.WriteLine($"{a}");
        sum = 0;
    }
    return a;
}

void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");          
        }
        Console.WriteLine();
    }
}

int[,] ChangeMassive(int[,] matrix, int rows, int columns)
{
    int[,] array = new int[columns, rows];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = rows;
            rows = columns;
            columns = temp;
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");          
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateMassive(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);            
        }
    }
    return array;
}

int rows = new Random().Next(5, 7);
int columns = new Random().Next(5, 7);
int[,] matrix = CreateMassive(rows, columns, 1, 10);
PrintArray(matrix);
int[,] changeMassive = ChangeMassive(matrix, rows, columns);
PrintArray2(changeMassive);
double middleArifmetical = MiddleArifmetical(matrix, rows, columns);