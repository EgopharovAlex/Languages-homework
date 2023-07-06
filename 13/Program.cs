Console.Clear();
int[] Array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Numbers = {Number(Array)}");



int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for ( int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}


int Number (int[] res)
{
    int n = 0;
    for (int i = 0; i < res.Length; i++)
    {
        if (i%2 == 0)
            n = n + res[i];
        else
            n = n + 0;
    }
   return n;
}