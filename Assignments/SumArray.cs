using System;

public class SumArray
{
    public void CalculateSumArray()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum of all elements in the array is : {sum}");
    }
}
