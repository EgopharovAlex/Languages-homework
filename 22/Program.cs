using System;
using static System.Console;

Clear();

Write("Enter number 1: ");
int number1= int.Parse(ReadLine());

Write("Enter number 2: ");
int number2 = int.Parse(ReadLine());

Write(Akerman(number1,number2));

int Akerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 +1;
    }
    else 
    if (number2 == 0)
    {
        return Akerman (number1 -1, 1);
    }
    else
    {
        return Akerman (number1 - 1,Akerman(number1,number2 - 1));
    }
}

// АБСОЛЮТНО нихера не понял формулу акермана но благо Википедия даже псевдокодом функции обладает