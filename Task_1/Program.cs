// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] arr)
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

double[,] CreateMassive(int rows, int columns, double begin, double end)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble();            
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите число строк:  ");
int columns = EnterData("Введите количество столбцов:  ");
double[,] matrix = CreateMassive(rows, columns, 1.0, 10.0);
PrintArray(matrix);