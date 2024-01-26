using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference1 = new Reference("Romans", 5, 3, 4);
        Scripture scripture1 = new Scripture(reference1, "And not only so, but we glory in tribulations also: knowing that tribulation worketh patience; And patience, experience; and experience, hope:");
        string userInput = "";

        while (userInput == "")
        {           
           if((scripture1.IsCompletelyHidden() != true))
            {
                Console.WriteLine(scripture1.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();
                
                if (userInput == "")
                {
                    Random random = new Random();
                    int randomNum = random.Next(1, 3);
                    scripture1.HideRandomWords(randomNum);
                } 
            }

            else
            {
                break;
            }
            
            
                          
        }

    }
}