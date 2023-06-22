Console.Clear();
Console.WriteLine("Enter x1 ");
double x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y1 ");
double y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z1 ");
double z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter x2 ");
double x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y2 ");
double y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z2 ");
double z2 = int.Parse(Console.ReadLine());

double res = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
Console.WriteLine($"res = {res:f2}");
