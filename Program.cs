using static class_workshop.Week1;

namespace class_workshop;

class Program
{
    static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            NullOperations nullChecker = new();
            nullChecker.PerformNullChecks();
            Console.WriteLine("Addition :" + calculator.Add(2,4));
            Console.WriteLine("Substract :" + calculator.Sub(10,4));
            Console.WriteLine("Multiply :" + calculator.Multi(10,8));
            Console.WriteLine("Div :" + calculator.Div(10,8));
            Console.WriteLine("oddeven finder :" + calculator.OddEven(10));
        }

}
