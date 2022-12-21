// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.

// Задача составлена некорректно: программа принимает позиции в массиве (координаты), и выдает значение этого элемента.
// Далее беспредел: "или указывает, что такого элемента нет".
// Тоесть: по логике равен нулю.
// С другой стороны, если поставить запятую в число 17, то получиться элемент массива [1, 7].
// В примере всего 4 столбика, а не 8, значит действительноэлемента нет.

// Буду решать: ввод с консоли адреса двумерного массива, рандомно созданного, и вывод значения элемента.

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
}

void FindAddress(int[,] matrix, int horizon, int vertical)
{
    if (horizon <= matrix.GetLength(0) && vertical <= matrix.GetLength(1))
    {
        Console.WriteLine($"{matrix[horizon, vertical]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
}

int[,] CreateMassive(int begin, int end)
{
    int rows = new Random().Next(0, 10);
    int columns = new Random().Next(0, 10);
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

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int horizon = EnterData("Введите позицию в строке:  ");
int vertical = EnterData("Введите позицию в столбце:  ");
int[,] matrix = CreateMassive(1, 25);
FindAddress(matrix, horizon, vertical);
PrintArray(matrix);