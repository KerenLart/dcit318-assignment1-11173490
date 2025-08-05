using System;

class Program
{
    static void Main(string[]args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("### DCIT 318: Assignment 1 ");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator ");
            Console.WriteLine("3. Triangle Type Identifier ");
            Console.WriteLine("4. Exit ");
            Console.WriteLine("Enter your choice (1-4): ");

            string? choice = Console.ReadLine();
            if (choice == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again");
                    break;


            }

        }
    }


    static void GradeCalculator()
    {
        Console.Write("Enter your numerical grade (0 - 100):");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid Grade. Must be between 0 and 100.");
            }
            else if (grade >= 80 && grade <= 100)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (grade >= 75)
            {
                Console.WriteLine("Your grade is: B+");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (grade >= 65)
            {
                Console.WriteLine("Your grade is: C+");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (grade >= 55)
            {
                Console.WriteLine("Your grade is: D+");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Your grade is: D");
            }
            else if (grade >= 45)
            {
                Console.WriteLine("Your grade is: E");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }            

        }

        else
        {
            Console.WriteLine("Invalid input. Please enter a number.\n");
        }
    }

    static void TicketPriceCalculator()
    {

    }

    static void TriangleTypeIdentifier()
    {

    }
}
