using System;
using static System.Console;

Clear();

Write("Количество строк: ");
int rows = int.Parse(ReadLine());

Write("Количество столбов: ");
int colomns = int.Parse(ReadLine());

double[,] array = GetArray ( rows, colomns, -10, 10 );

PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)  
{
    Random random = new Random();
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double randomNum = minValue + random.NextDouble() * (maxValue - minValue);
            result[i,j] = randomNum;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j<inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:F1} ");
        }
        WriteLine();
    }
}