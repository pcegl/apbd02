// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var n in numbers)
    {
        sum += n;
    }

    return (double) sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMaxValue(int[] numbers)
{
    int maxVal = numbers[0];
    foreach (var number in numbers)
    {
        if (maxVal < number)
        {
            maxVal = number;
        }
    }
    return maxVal;
}