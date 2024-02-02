using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breating activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
            }

            else if (userSelection == "2")
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }

            else if (userSelection == "3")
            {

            }

            else if (userSelection == "4")
            {
                break;
            }

            else
            {
                Console.WriteLine("\nInvalid entry. Please enter 1-4.\n");
            }
        }

    }
}