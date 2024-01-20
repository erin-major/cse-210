using System;

class Program
{
    static void Main(string[] args)
    {
        // Create string for selection and create journal. 
        string selection = "";
        Journal journal = new Journal();

        // Loop through selection menu until user decides to exit.
        while (selection != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                journal.AddEntry();
            }

            else if (selection == "2")
            {
                journal.DisplayAll();
            }

            else if (selection == "3")
            {
                journal.LoadFromFile();
            }

            else if (selection == "4")
            {
                journal.SaveToFile();
            }

            else if (selection == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid entry. Please enter 1-5.");
            }
        }
    }
}