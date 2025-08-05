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
        Console.Write("Enter your age:");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket price: GHC 7");
            else
                Console.WriteLine("Ticket price: GHC 10");
        }
        else 
            Console.WriteLine("Invalid input. Please enter a valid age. \n");
    }

    static void TriangleTypeIdentifier()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");
        double side1, side2, side3;

        Console.Write("Side 1: ");
        if (!double.TryParse(Console.ReadLine(),out side1))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Console.Write("Side 2: ");
        if (!double.TryParse(Console.ReadLine(), out side2))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Console.Write("Side 3: ");
        if (!double.TryParse(Console.ReadLine(), out side3))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Sides must be positive numbers.");
            return;
        }

        if ((side1 + side2 > side3) &&
            (side1 + side3 > side2) &&
            (side2 + side3 > side1))
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }

        else
        {
            Console.WriteLine("The values entered do not form a valid triangle.");
        }

    }
}
