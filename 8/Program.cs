Console.Clear();
Console.WriteLine("Enter number ");
int n = int.Parse(Console.ReadLine());
int [] result = new int [n];
for (int i = 1; i<=n; i++)
    result[i-1] = ((i * i) * i);
for (int i = 0; i<n; i++)
    Console.WriteLine($"{result[i]} ");
Console.WriteLine();