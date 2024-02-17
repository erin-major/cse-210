using System;
using System.Globalization;

public class ItemManager
{
    private List<Item> _ownedItems = new List<Item>();
    private List<Item> _wishListItems = new List<Item>();

    public void Start()
    {
        Console.WriteLine("Welcome to the Collection Manager!");
        Console.WriteLine("----------------------------------");

        while(true)
        {
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
                string itemType = DisplayItemMenu("add");
                AddItem(itemType);

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
                Console.WriteLine("\nThank you! Goodbye!");
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

    public string DisplayItemMenu(string action)
    {
        string itemType = "";
        
        while(true)
        {
            Console.Clear();
            Console.WriteLine("The item categories are:");
            Console.WriteLine(" 1. Books");
            Console.WriteLine(" 2. Movies");
            Console.WriteLine(" 3. TV Shows");
            Console.WriteLine(" 4. Video Games");
            Console.WriteLine(" 5. Board Games");
            Console.WriteLine(" 6. Miscellaneous Collectibles");
            Console.Write($"Which type of item would you like to {action} (1-6)? ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
                {
                    itemType = "book";
                    break;
                }
                else if (userInput == "2")
                {
                    itemType = "movie";
                    break;
                }
                else if (userInput == "3")
                {
                    itemType = "tv show";
                    break;
                }
                else if (userInput == "4")
                {
                    itemType = "video game";
                    break;
                }
                else if (userInput == "5")
                {
                    itemType = "board game";
                    break;  
                }
                else if (userInput == "6")
                {
                    itemType = "misc. item";
                    break;
                }
                else
                {
                    Console.WriteLine("\n Invalid entry. Please enter 1-6.");
                    Thread.Sleep(3000);
                }
        }
        
        return itemType;
    }

    public void AddItem(string itemType)
    {
        Console.Write($"\nWhat is the name of your {itemType}? ");
        string name = Console.ReadLine();

        if (itemType == "book")
        {
            Console.Write($"Who is the author of your book? ");
            string author = Console.ReadLine();
            Console.Write($"What format is your book in? ");
            string format = Console.ReadLine();
            Book book = new Book(name, author, format);
            AddToList(book);
        }

        else if (itemType == "movie")
        {
            Console.Write($"What year was your movie released? ");
            string year = Console.ReadLine();
            Console.Write($"What format is your movie in? ");
            string format = Console.ReadLine();
            Movie movie = new Movie(name, year, format);
            AddToList(movie);
        }

        else if (itemType == "tv show")
        {
            Console.Write($"Which seasons do you have? ");
            string seasons = Console.ReadLine();
            Console.Write($"What format is your tv show in? ");
            string format = Console.ReadLine();
            Console.Write($"What version of your tv show do you have? (Press enter to skip) ");
            string version = Console.ReadLine();

            if (version == "")
            {
                TVShow show = new TVShow(name, seasons, format);
                AddToList(show);
            }
            else
            {
                TVShow show = new TVShow(name, seasons, format, version);
                AddToList(show);
            }
        }
        else if (itemType == "video game")
        {
            Console.Write($"What system is the game for? ");
            string system = Console.ReadLine();
            Console.Write($"What version of your game do you have? (Press enter to skip) ");
            string version = Console.ReadLine();
            if (version == "")
            {
                VideoGame videoGame = new VideoGame(name, system);
                AddToList(videoGame);
            }
            else
            {
                VideoGame videoGame = new VideoGame(name, system, version);
                AddToList(videoGame);
            }
        }
        else if (itemType == "board game")
        {
            Console.Write($"What version of your game do you have? (Press enter to skip) ");
            string version = Console.ReadLine();
            if (version == "")
            {
                BoardGame boardGame = new BoardGame(name);
                AddToList(boardGame);
            }
            else
            {
                BoardGame boardGame = new BoardGame(name, version);
                AddToList(boardGame);
            }
        }
        else if (itemType == "misc. item")
        {
            Console.Write($"Please give a brief description of your item: ");
            string description = Console.ReadLine();
            MiscItem miscItem = new MiscItem(name, description);
            AddToList(miscItem);
        }
    }

    public void AddToList(Item item)
    {
        while(true)
        {
            Console.Write("\nWhich list would you like to add this to? (collection/wishlist) ");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "collection")
            {
                _ownedItems.Add(item);
                break;
            }
            else if (userChoice.ToLower() == "wishlist")
            {
                _wishListItems.Add(item);
                break;
            }
            else
            {
                Console.WriteLine("\n Invalid entry. Please enter 'collection' or 'wishlist'.");
                Thread.Sleep(3000);
            }
        }

        Console.WriteLine("Success! Your item has been added!");
        Thread.Sleep(3000);
        Console.Clear();

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