Console.WriteLine("            *   *   *");
Console.WriteLine("CREATING AND PRINTING 2D-ARRAYS CODE");
Console.WriteLine("");
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columnss: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DMatrix(rows, columns, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
Console.WriteLine($"Summary of elements in main diagonal is {SumElementMainDiag(myArray)}");
Console.WriteLine();
int[,] myNewArray = CreateMy2DMatrix(rows, columns);
Console.WriteLine();
Console.WriteLine("My new array: ");
Print2DArray(myNewArray);
Console.WriteLine();
int[,] myModifyArray = ModifyMy2DMatrix(myNewArray);
Console.WriteLine("My modified array: ");
Print2DArray(myModifyArray);


int[,] Create2DMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

int SumElementMainDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j) sum += array[i,j];
        }
    }
    return sum;
}

int[,] CreateMy2DMatrix (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] ModifyMy2DMatrix (int[,] array)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if ((i%2 == 1) && (j%2 == 1)) array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}
