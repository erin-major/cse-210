using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {   
        Entry newEntry = new Entry();

        DateTime today = DateTime.Now;
        newEntry._date = today.ToShortDateString();
        PromptGenerator promptGen = new PromptGenerator();
        
        // Check to make sure the user enters set or custom for the prompt.
        bool validPromptVersion = false;

        while (!validPromptVersion)
        {
            Console.Write("\nDo you want a set prompt or do you want to add your own? (SET/CUSTOM): ");
            string promptType = Console.ReadLine();

            // Generate a random prompt from the list. 
            if (promptType.ToLower() == "set")
            {
                validPromptVersion = true;
                newEntry._promptText = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{newEntry._promptText} (Type SKIP to skip this question)");
            }

            // Allow the user to set their own prompt
            else if (promptType.ToLower() == "custom")
            {
                validPromptVersion = true;
                newEntry._promptText = promptGen.CreateCustomPrompt();
                Console.WriteLine("Now answer your prompt.");
            }

            else
            {
                Console.WriteLine("Invalid response. Please enter SET or CUSTOM.");
            }           
        }

        newEntry._entryText = Console.ReadLine();

        // Continue to suggest prompts if the user decides to skip the selected random prompt.
        while (newEntry._entryText.ToLower() == "skip")
        {
            newEntry._promptText = promptGen.GetRandomPrompt();
            Console.WriteLine($"{newEntry._promptText} (Type SKIP to skip this question)");
            newEntry._entryText = Console.ReadLine();
        }
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {       
            e.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("\nWhat is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                // I used | because it's a character that isn't typed regularly in sentences, so the split when 
                // loading a file won't accidently happen mid sentence. 
                outputFile.WriteLine($"{e._date} | {e._promptText} | {e._entryText}");                
            }
        }        
    }

    public void LoadFromFile()
    {
        // Try catch to make sure the file the user is trying to load exists. 
        try
        {
            Console.WriteLine("\nWhat is the filename?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Entry newEntry = new Entry();
                string[] parts = line.Split("|");
                newEntry._date = parts[0].Trim();
                newEntry._promptText = parts[1].Trim();
                newEntry._entryText = parts[2].Trim();

                _entries.Add(newEntry);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("\nError. File not found.");           
        }
    }
}