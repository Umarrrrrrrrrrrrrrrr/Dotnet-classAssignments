using System;

public class SumUsingWhile
{
    public void PrintNumber()
    {
        int i = 1;
        while (i <= 20)
        {
            if (i % 4 == 0)
            {
                i++;
                continue;  //skip multiple of 4
            }

            if (i == 15)
            {
                break;
            }

            Console.WriteLine(i);
            i++;

        }
    }
}