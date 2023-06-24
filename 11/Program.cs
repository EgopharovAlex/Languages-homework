int[] array = RandomArray(8);
int[] RandomArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
Console.WriteLine($"[{String.Join("; ", array)}]");