using System;
using static System.Console;

Clear();

Write("Количество строк: ");
int rows = int.Parse(ReadLine());

Write("Количество столбов: ");
int colomns = int.Parse(ReadLine());

int[,] array = GetArray(rows, colomns,0,10);

PrintArray(array);
FindMiddle(array);

int [,] GetArray(int m, int n,int minValue,int maxValue)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}

void PrintArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j  < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void FindMiddle (int[,] inArray)
{
    for (int j = 0; j  < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        Write($" | { sum / inArray.GetLength(0):F1} ");
    }
}