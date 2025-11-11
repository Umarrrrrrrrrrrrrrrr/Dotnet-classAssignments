using System;

public class SumUsingFor
{
    public void CalculateSum()
    {
        // Calculating the sum of the number from 1 to N:
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"The sum from 1 to {N} is : {sum}");

    }
}