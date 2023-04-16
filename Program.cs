// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateArray (int length1, int lenght2)
{
    double [,] Array = new double [length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().NextDouble();
        }
    }
    return Array;
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           System.Console.Write("{0,6:F2}", Array[i,j]);
           
        }
        System.Console.WriteLine();
    }
}

PrintArray(CreateArray(4, 4));