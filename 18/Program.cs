using System;
using static System.Console;

Clear();

Write("Строка искомого числа: ");
int a = int.Parse(ReadLine());

Write("Столбец искогомого числа: ");
int b = int.Parse(ReadLine());

int[,] array = GetArray(5, 5,0,10);

PrintArray(array);


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
    {
        if (a<0 | a>inArray.GetLength(0) | b<0 | b>inArray.GetLength(1))
            {
                WriteLine("Элемента нет ");
            }
            else 
            {
                WriteLine($"Число = {inArray[a,b]}");
            }
    }
}
