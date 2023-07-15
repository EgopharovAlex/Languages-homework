using System;
using static System.Console;

Clear();

Write("Enter number 1: ");
int number1= int.Parse(ReadLine());

Write("Enter number 2: ");
int number2 = int.Parse(ReadLine());

Write(PrintSum(number1 - 1, number2));

int PrintSum (int number1, int number2)
{
    int res = number1;
    if (number1 == number2)
    return 0;
    {
        number1++;
        res = number1 + PrintSum(number1,number2);
        return res;
    }
}