using System;

public class PasswordChecks()
{
    public void ValidatePassword()
    {
        try
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters");
            }
            Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}