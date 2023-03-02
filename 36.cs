static int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(int[] arrayFill)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFill.Length; i++)
    {
        arrayFill[i] = digit.Next(100,1000);
    }
}

static void arraySumOddPosition(int[] arrayRandom)
{
    int sum = 0;
    for (int i = 1; i<arrayRandom.Length; i=i+2)
    {
        sum = sum + arrayRandom[i];
    }
    System.Console.WriteLine($"Amount of numbers situated on odd position = {sum}");
}

int arraySize = Prompt("Input array size: ");
int[] array = new int[arraySize];

arrayFilling(array);

foreach (int ch in array)
{
    System.Console.Write($" / {ch}");
}
System.Console.WriteLine(" /");

arraySumOddPosition(array);