using System;

public class ItemManager
{
    private List<Item> _ownedItems = new List<Item>();
    private List<Item> _wishListItems = new List<Item>();

    public void Start()
    {
        while(true)
        {
            Console.WriteLine("Welcome to the Collection Manager!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Here are your options:");
            Console.WriteLine(" 1. Add item to collection or wishlist");
            Console.WriteLine(" 2. Remove item from collection or wishlist");
            Console.WriteLine(" 3. Move item from wishlist to collection");
            Console.WriteLine(" 4. Display a collection or wishlist");
            Console.WriteLine(" 5. Save my collection and wishlist");
            Console.WriteLine(" 6. Load a collection and wishlist");
            Console.WriteLine(" 7. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {

            }
            else if (userChoice == "2")
            {
                
            }
            else if (userChoice == "3")
            {
                
            }
            else if (userChoice == "4")
            {
                
            }
            else if (userChoice == "5")
            {
                SaveList();   
            }
            else if (userChoice == "6")
            {
                LoadList();
            }
            else if (userChoice == "7")
            {
                Console.WriteLine("\nThank you!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid entry. Please enter 1-7.");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }

    }

    public void AddItem()
    {

    }

    public void RemoveItem()
    {

    }

    public void DisplayFullList()
    {

    }

    public void DisplayCategory()
    {

    }

    public void DisplayCustomSearch()
    {

    }

    public void SortCategory()
    {

    }

    public void SaveList()
    {

    }

    public void LoadList()
    {

    }

}