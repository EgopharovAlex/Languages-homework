int NumDegree( int a, int b)
{
    int result = 1;
    for(int i=0; i<b; i++)
      result *= a;
    return result;
}

Console.Clear();
Console.WriteLine("Enter numer A ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numer B ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"number {a} in degree {b} = {NumDegree(a,b)} ");