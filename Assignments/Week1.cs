namespace class_workshop        

{
    class Week1
    {

            // Question number One - 1
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
            public int Multi(int a, int b)
            {
                return a * b;
            }
            public int Div(int a, int b)
            {
                return a / b;
            }

            // odd even
            public string OddEven(int num)
            {
                return (num % 2 == 0) ? $"{num} is Even" : $"{num} is odd";

            }

            // public void Nullfinder()
            // {
            //     string name = null;
            //     int
            // }

        }
    }
}
