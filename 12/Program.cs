Console.Clear();
int[] Array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Even numbers = {EvenNumbers(Array)}");




int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for ( int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}

int EvenNumbers(int[] res)
{
    int count = 0;
    foreach(int item in res)
    {
        if ( item % 2 == 0)
        count++;
    }
    return count;
}