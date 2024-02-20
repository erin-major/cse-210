using System;
using System.Formats.Asn1;
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
                if (_ownedItems.Count == 0 & _wishListItems.Count == 0)
                {
                    Console.WriteLine("You do not have any items in your collection list or wishlist. Please add some items first.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    RemoveItem(); 
                }     
            }
            else if (userChoice == "3")
            {
                if (_wishListItems.Count == 0)
                {
                    Console.WriteLine("You do not have any items in your wishlist. Please add some items first.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    MoveBetweenLists();
                }
            }
            else if (userChoice == "4")
            {
                if (_ownedItems.Count == 0 & _wishListItems.Count == 0)
                {
                    Console.WriteLine("You do not have any items in your collection list or wishlist. Please add some items first.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    List<Item> workingList = ListSelection();
                    DisplayFullList(workingList); 
                }
            }
            else if (userChoice == "5")
            {
                if (_ownedItems.Count == 0 & _wishListItems.Count == 0)
                {
                    Console.WriteLine("You do not have any items in your collection list or wishlist. Please add some items first.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    SaveList();  
                }
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
                    Console.WriteLine("\nInvalid entry. Please enter 1-6.");
                    Thread.Sleep(3000);
                }
        }  
        return itemType;
    }

    public void AddItem(string itemType)
    {
        List<Item> workingList = ListSelection(); 
        Console.Write($"\nWhat is the name of your {itemType}? ");
        string name = Console.ReadLine();

        if (itemType == "book")
        {
            Console.Write($"Who is the author of your book? ");
            string author = Console.ReadLine();
            Console.Write($"What format is your book in? ");
            string format = Console.ReadLine();
            Book book = new Book(name, author, format);
            workingList.Add(book);
        }
        else if (itemType == "movie")
        {
            Console.Write($"What year was your movie released? ");
            string year = Console.ReadLine();
            Console.Write($"What format is your movie in? ");
            string format = Console.ReadLine();
            Movie movie = new Movie(name, year, format);
            workingList.Add(movie);
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
                workingList.Add(show);
            }
            else
            {
                TVShow show = new TVShow(name, seasons, format, version);
                workingList.Add(show);
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
                workingList.Add(videoGame);
            }
            else
            {
                VideoGame videoGame = new VideoGame(name, system, version);
                workingList.Add(videoGame);
            }
        }
        else if (itemType == "board game")
        {
            Console.Write($"What version of your game do you have? (Press enter to skip) ");
            string version = Console.ReadLine();
            if (version == "")
            {
                BoardGame boardGame = new BoardGame(name);
                workingList.Add(boardGame);
            }
            else
            {
                BoardGame boardGame = new BoardGame(name, version);
                workingList.Add(boardGame);
            }
        }
        else if (itemType == "misc. item")
        {
            Console.Write($"Please give a brief description of your item: ");
            string description = Console.ReadLine();
            MiscItem miscItem = new MiscItem(name, description);
            workingList.Add(miscItem);
        }
        workingList.Sort();
        Console.WriteLine("Success! Your item has been added!");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public List<Item> ListSelection()
    {
        while(true)
        {
            Console.Write("\nWhich list would you like to work with? (collection/wishlist) ");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "collection")
            {
                return _ownedItems;
            }
            else if (userChoice.ToLower() == "wishlist")
            {
                return _wishListItems;
            }
            else
            {
                Console.WriteLine("\n Invalid entry. Please enter 'collection' or 'wishlist'.");
                Thread.Sleep(3000);
            }
        }
    }
    
    public void RemoveItem()
    {
        List<Item> workingList = ListSelection();
        DisplayFullList(workingList);
        Console.Write("\nWhich item do you want to remove? ");
        int removeNum = int.Parse(Console.ReadLine()) - 1;
        workingList.Remove(workingList[removeNum]);

        Console.WriteLine("\nSuccess! Your item has been removed.");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void DisplayFullList(List<Item> list)
    {
        Console.WriteLine();
        int displayNumber = 1;
        string itemDisplay = "";
        foreach (Item i in list)
        {
            itemDisplay = i.DisplayItem();
            Console.WriteLine($"{displayNumber}) {itemDisplay}");
            displayNumber += 1;
        }
        Console.WriteLine();
    }

    public void MoveBetweenLists()
    {
        Console.WriteLine("\nHere is your wishlist: ");
        DisplayFullList(_wishListItems);
        Console.Write("\nWhich item do you want to move to your collection? ");
        int moveNum = int.Parse(Console.ReadLine()) - 1;
        _ownedItems.Add(_wishListItems[moveNum]);
        _wishListItems.Remove(_wishListItems[moveNum]);

        Console.WriteLine("\nSuccess! Your item has been moved to your collection.");
        Thread.Sleep(3000);
        Console.Clear();

    }

    public void SaveList()
    {
        Console.Write("What is the filename for the output file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Owned");
            
            foreach (Item i in _ownedItems)
            {
                outputFile.WriteLine(i.GetStringRepresentation());
            }

            outputFile.WriteLine("WishList");
            
            foreach (Item i in _wishListItems)
            {
                outputFile.WriteLine(i.GetStringRepresentation());
            }
        }

        Console.WriteLine("\nSuccess! Your lists were saved to a file.");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void LoadList()
    {
        try
        {
            Console.Write("What is the filename for the file? ");
            string fileName = Console.ReadLine(); 
            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<Item> workingList = _ownedItems;
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                if (parts[0] == "WishList")
                {
                    workingList = _wishListItems;
                }

                if (parts[0] == "Movie")
                {
                    Movie movie = new Movie(parts[1], parts[2], parts[3]);
                    workingList.Add(movie);
                }
                else if (parts[0] == "Book")
                {
                    Book book = new Book(parts[1], parts[2], parts[3]);
                    workingList.Add(book);
                }
                else if (parts[0] == "TVShow")
                {
                    string version = null;
                    if (parts.Length == 5)
                    {
                        version = parts[4];
                    }
                    TVShow tvShow = new TVShow(parts[1], parts[2], parts[3], version);
                    workingList.Add(tvShow);
                }
                else if (parts[0] == "VideoGames")
                {
                    string version = null;
                    if (parts.Length == 4)
                    {
                        version = parts[3];
                    }
                    VideoGame videoGame = new VideoGame(parts[1], parts[2], version);
                    workingList.Add(videoGame);
                }  
                else if (parts[0] == "BoardGames")
                {
                    string version = null;
                    if (parts.Length == 3)
                    {
                        version = parts[2];
                    }
                    BoardGame boardGame = new BoardGame(parts[1], version);
                    workingList.Add(boardGame);
                }                
                else if (parts[0] == "MiscItem")
                {
                    MiscItem miscItem = new MiscItem(parts[1], parts[2]);
                    workingList.Add(miscItem);
                }
            }

            Console.WriteLine("\nSuccess! Your lists were loaded from the file.");
            Thread.Sleep(3000);
            Console.Clear();

        } catch (FileNotFoundException e)
        {
            Console.WriteLine("\nInvalid entry! The file was not found.\n");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}