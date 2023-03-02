static int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(double[] arrayFill)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFill.Length; i++)
    {
        arrayFill[i] =  Math.Round(digit.Next(1,101)+digit.NextDouble(), 2);
    }
}

static void arrayMaxMinDifference(double[] arrayRandom)
{
    double difference = 0;
    double max = 0;
    double min = arrayRandom[0];
    
    for (int i = 0; i<arrayRandom.Length; i++)
    {
        if(arrayRandom[i]>max)
        {
            max = arrayRandom[i];
        }

    }

    for(int j=0; j<arrayRandom.Length; j++)
    {
        if(arrayRandom[j]<min)
        {
            min = arrayRandom[j];
        }
    }
     
    System.Console.WriteLine($"Max = {max} and Min = {min}");
    difference = Math.Round(max - min, 2);
    System.Console.WriteLine($"Difference between numbers of max and min value = {difference}");
}

int arraySize = Prompt("Input array size: ");
double[] array = new double[arraySize];

arrayFilling(array);
Console.WriteLine(string.Join(" / ", array));

arrayMaxMinDifference(array);