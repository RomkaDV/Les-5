static int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int arraySize = Prompt("Input array size: ");
int[] array = new int[arraySize];


static void arrayFilling(int[] arrayFill)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFill.Length; i++)
    {
        arrayFill[i] = digit.Next(100,1000);
    }
}

static void countEvenDigit(int[] arrayCountEven)
{
    int countEven = 0;
    for (int i = 0; i < arrayCountEven.Length; i++)
    {
        if (arrayCountEven[i]%2 == 0)
        {
            countEven++;
        }
    }
    System.Console.WriteLine($"Amount of even numbers = {countEven}");
}

arrayFilling(array);

foreach (int ch in array)
{
    System.Console.Write($" / {ch}");
}
System.Console.WriteLine(" /");

countEvenDigit(array);