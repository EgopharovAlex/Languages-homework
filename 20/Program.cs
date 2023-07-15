using System;
using static System.Console;

Clear();

Write("Enter number: ");
int number = int.Parse(ReadLine());
WriteLine(PrintNumbers(number));

string PrintNumbers (int number)
{
    if (number == 1)
    {
        return "1";
    }
    string s = (number.ToString()) + ", " + PrintNumbers(number - 1);
    return s;
}