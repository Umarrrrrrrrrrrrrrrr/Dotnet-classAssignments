using System;

public class NumberConversion
{
    public void ConvertIntoInteger()
    {
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);         //may throw FormatException
            Console.WriteLine($"You entered the number {number}");

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }
}