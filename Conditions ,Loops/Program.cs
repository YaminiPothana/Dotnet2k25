using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Calling all the methods
            ForLoop();
            GreetUser();
            WishBasedOnTime(21);
            CheckIfElseCondition();
            UsingWhileLoop();
            UsingDoWhileLoop();
            CheckRainbowColor();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    // 1. Taking User Input and Greeting
    static void GreetUser()
    {
        try
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            Console.WriteLine("Hello " + name);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 2. Wishing based on Time
    static void WishBasedOnTime(int time)
    {
        try
        {
            if (time < 0 || time > 24)
                throw new ArgumentOutOfRangeException("Time should be between 0 and 24."); //Throws an exception, when an argument is out of an acceptable range. 

            if (time < 12)
            {
                Console.WriteLine("Good Morning Yamini");
            }
            else if (time > 13 && time < 16)
            {
                Console.WriteLine("Good Afternoon Yamini");
            }
            else
            {
                Console.WriteLine("Good Evening Yamini");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 3. If-Else Condition Example
    static void CheckIfElseCondition()
    {
        try
        {
            int p = 5;
            if (p > 6)
            {
                Console.WriteLine("Hai");
            }
            else if (p < 6)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine(p);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 4. For Loop with Break Condition
    static void ForLoop()
    {
        try
        {
            for (int a = 1; a < 6; a++)
            {
                for (int b = 1; b < 6; b++)
                {
                    if (a == b)
                        break;
                    Console.WriteLine($"{a} {b}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 5. While Loop Example
    static void UsingWhileLoop()
    {
        try
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Cognine Technologies");
                i++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 6. Do-While Loop Example
    static void UsingDoWhileLoop()
    {
        try
        {
            int j = 1;
            do
            {
                Console.WriteLine("Do Good");
                j++;
            }
            while (j <= 5);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // 7. Using Switch Case for Rainbow Colors
    static void CheckRainbowColor()
    {
        try
        {
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(color))
                throw new ArgumentException("Color cannot be empty."); // Throws an exception, when an invalid argument is passed.

            switch (color)
            {
                case "Violet":
                case "Indigo":
                case "Blue":
                case "Green":
                case "Yellow":
                case "Orange":
                case "Red":
                    Console.WriteLine(color);
                    break;
                default:
                    Console.WriteLine("Not a Rainbow Color");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
