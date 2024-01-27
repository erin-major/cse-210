using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference1 = new Reference("Romans", 5, 3, 4);
        Scripture scripture1 = new Scripture(reference1, "And not only so, but we glory in tribulations also: knowing that tribulation worketh patience; And patience, experience; and experience, hope:");
        string userInput = "";
        Random random = new Random();
            
        while(true)
        {
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            
            if (scripture1.IsCompletelyHidden())
            {
                break;
            }
            else if (userInput == "")
            {                    
                int randomNum = random.Next(1, 4);
                scripture1.HideRandomWords(randomNum);
                Console.WriteLine(scripture1.GetDisplayText());
            }
            else if (userInput.ToLower() == "quit")
            {
                break;
            }   
        }                          
    }
}

// I showed creativity by only hiding words that haven't been hidden already.
// I also didn't hide punctuation, because I felt like that gave an incorrect appreance
// of the length of the word. The punctuation remains, but the rest of the word is hidden.

