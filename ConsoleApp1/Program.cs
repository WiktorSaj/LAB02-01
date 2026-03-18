// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Math
{

    static int add(int a, int b)
    {
        return a + b;
    }

    static int sub(int a, int b)
    {
        return a - b;
    }

    static int mul(int a, int b)
    {
        return a * b;
    }

    static int div(int a, int b)
    {
        return a / b;
    }

    static double CalculateAverage(int[] values)
    {
        
        double sum = 0;

        foreach (var number in values)
        {
            sum += number;
        }
        return sum / values.Length;
    }

    static int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var number in values)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static int CalculateMin(int[] values)
    {
        return 0;
    }
    

}