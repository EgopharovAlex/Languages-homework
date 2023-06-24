Console.Clear();
Console.Write("Enter number ");
int num = int.Parse(Console.ReadLine());
if (num < 100)

{Console.Write("no 3rd number");
}
else
{
    while (num > 999)
    {
        num = num /10;
    }
    {
        num = num % 10;
        }
    Console.Write(num);
}