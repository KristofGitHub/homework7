// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("");
Console.WriteLine("            *   *   *");
Console.WriteLine("TASK # 1");
Console.WriteLine("");
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DMatrix(rows, columns);
Print2DArray(myArray);

double[,] Create2DMatrix (int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 2 - 1, 1);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    Console.WriteLine("Yours array: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("");
Console.WriteLine("            *   *   *");
Console.WriteLine("TASK # 2");
Console.WriteLine("");
Console.WriteLine("Input number of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = Create2DMatrix1(rows1, columns1);
Print2DArray1(myArray1);

Console.WriteLine("Input number of rows finding elements of array: ");
int rowFE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns finding elements of array: ");
int columnFE = Convert.ToInt32(Console.ReadLine());

FindElement(myArray1, rowFE, columnFE);

int[,] Create2DMatrix1 (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray1(int[,] array)
{
    Console.WriteLine("Yours array: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array, int rowFE, int columnFE)
{
    Console.WriteLine("");
    if ((array.GetLength(0) + 1) >= rowFE)
    {
        if ((array.GetLength(1) + 1) >= columnFE) Console.WriteLine($"Your elements is {array[rowFE - 1, columnFE - 1]}");
        else Console.WriteLine("This element does not exist in your array");
    }
    else Console.WriteLine("This element does not exist in your array");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("");
Console.WriteLine("            *   *   *");
Console.WriteLine("TASK # 3");
Console.WriteLine("");
Console.WriteLine("Input number of rows: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columnss: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = Create2DMatrix2(rows, columns);
Print2DArray2(myArray2);
Console.WriteLine();
Console.WriteLine($"Arithmetic mean of every columns is: ");
Console.WriteLine();
ArithmeticMeanCol(myArray2);

int[,] Create2DMatrix2 (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void Print2DArray2(int[,] array)
{
    Console.WriteLine("Yours array: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void ArithmeticMeanCol(int[,] array)
{
    double sum = 0;
    double rows = array.GetLength(0);
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++) sum += (array[i,j])/(rows);
        Console.Write($"Column {j} - {sum}; ");
        sum = 0;
    }
    Console.WriteLine();
}