public class MultipleAdds
{
    // Method for adding three numbers
    public void Addition(int a, int b, int c)
    {
        try
        {
            int sum = a + b + c;
            Console.WriteLine($"Addition of three numbers ({a}, {b}, {c}) = {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while adding three numbers: {ex.Message}");
        }
    }

    // Method for adding two numbers (method overloading)
    public void Addition(int a, int b)
    {
        try
        {
            int sum = a + b;
            Console.WriteLine($"Addition of two numbers ({a}, {b}) = {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while adding two numbers: {ex.Message}");
        }
    }
}