﻿
bool runAgain = true;
    while(runAgain == true)
    {
        int num1;
        int num2;

        Console.WriteLine("Please enter two numbers and the program will decide which is great, less, or equal to");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}");
            Console.WriteLine($"and {num2} is less than {num1}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num1} is less than {num2}");
            Console.WriteLine($"and {num2} is greater than {num1}");
        }
        else
        {
            Console.WriteLine("They are equal.");
        }


        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }