using System;
class Myclass
{

    static void Main(string[] args)
    {
        for(int a = 1;a<3;a++)
        {
            for(int b=1;b<3;b++)
            {
                if(a == b)
                break;
                Console.WriteLine(a + " " + b);
            }
        }
        
        //using if,else ,else-if condition
        int Time = 21;
        
        if (Time < 12)
        {
            Console.WriteLine("Good Morning Yamini");
        }
        else if (Time > 13 && Time < 16)
        {
            Console.WriteLine("Good Afternoon Yamini");
        }
        else
        {
            Console.WriteLine("Good Evening Yamini");
        }

        // taking input from the user
        string Name;
        Console.Write("Enter your Name :");
        Name = Console.ReadLine();
        Console.WriteLine("Good Morning " + Name);

        //using switch case conditional statement

        string color ;
       Console.WriteLine("Enter Color");
       color= Console.ReadLine();
        switch (color)
        {

            case "Violet":
                Console.WriteLine("violet");
                break;
            case "Indigo":
                Console.WriteLine("Indigo");
                break;
            case "Blue":
                Console.WriteLine("Blue");
                break;
            case "Green":
                Console.WriteLine("Green");
                break;
            case "Yellow":
                Console.WriteLine("Yellow");
                break;
            case "Orange":
                Console.WriteLine("Orange");
                break;
            case "Red":
                Console.WriteLine("Red");
                break;
            default: Console.WriteLine("Not a RainBow colour");
                break;
        }
        // looping statements
        //usage of while loop  
        int i= 1;
        while (i <= 5)
        {
            Console.WriteLine("Cognine Technologies");
            i++;
        }

        //Using do while loop
        int j = 1;
        do
        {
            Console.WriteLine(" Do Good ");
            j++;
        }
        while (j <= 5);
        // if statements
        int p = 5;
        if (p > 6)
        {
            Console.WriteLine("Hai");
        }
        else if( p < 6)
        {
            Console.WriteLine("Hello");
            
        }
        else
        {
            Console.WriteLine(p);
        }



    }
}