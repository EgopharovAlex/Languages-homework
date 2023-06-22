Console.Clear();
Console.WriteLine("Enter 5 numbers ");
int n = int.Parse(Console.ReadLine());
int a = n/10000;
int b = ((n/1000)%10);
int c = ((n%100)/10);
int d = n%10;

if ((a == d) && (b == c))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}