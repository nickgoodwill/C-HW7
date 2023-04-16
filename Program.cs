// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] CreateArray (int length1, int lenght2)
// {
//     double [,] Array = new double [length1, lenght2];
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//            Array[i,j] = new Random().NextDouble();
//         }
//     }
//     return Array;
// }

// void PrintArray(double[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//            System.Console.Write("{0,6:F2}", Array[i,j]);
           
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintArray(CreateArray(4, 4));

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random(). Next(1,10);
//         }
//     }
// }

// void Digit(int[,] matr)
// {
//     int k = new Random(). Next(1,10);
//     Console.WriteLine(k);
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i,j] == k)
//             {
//                 Console.WriteLine($"число {k} есть в матрице");
                
//             } 
//             else
//             {
//                 Console.WriteLine($"числа {k} нет в матрице");
                
//             }
//         }
//     }
// }

// int [,] matrix = new int [4,4];

// FillArray(matrix);
// PrintArray(matrix);
// Digit(matrix);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random(). Next(1,10);
        }
    }
}


int [,] matr = new int [4, 4];

FillArray(matr);
PrintArray(matr);

double aversum = 0;
double aver = 0;
double qty = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            aversum += matr[j,i];
            qty += 1;
        }
        Console.WriteLine();
        Console.WriteLine("Сумма " + (i + 1) + " столбца равна " + aversum);
        aver = aversum / qty;
        Console.WriteLine();
        Console.WriteLine("Средняя арифметическая " + (i + 1) + " столбца равна " + aver);
        aversum = 0;
        aver = 0;
    }