Console.Clear();
int[] Array = GetArray(5, 1, 100);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Diff Numbers = {Diff(Array)}");



int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for ( int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}

int Diff (int[] res)
{
    int N = 0;
    int max = res[0];
    int min = res[0];
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] > max)
        max = res[i];
        {
            if (res[i] < min)
            min = res[i];
        }
    }
    return N = max - min;
}
