using System;


    // Question number 2
// public class Nullable
// {
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string? username = null;

            //Ternary operations
          Console.WriteLine( (username == null) ? "username is not available" : username);

 
            //Null-coalescing Assignment Operator
            username ??= "DefaultUser";
        Console.WriteLine($"Updated username : {username} ");
            // return username
        }
    }
// }