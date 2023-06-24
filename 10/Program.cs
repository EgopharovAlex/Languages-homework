int SumNumbers(int n)
{
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n = n / 10;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Enter numer N ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{SumNumbers(n)} ");