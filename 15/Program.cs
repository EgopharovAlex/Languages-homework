Console.Clear();

int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int[] InputArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Enter {i + 1}-st element");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int lenght = Promt("Enter number of elements ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Numbers more then 0 are = {CountPositiveNumbers(array)} ");