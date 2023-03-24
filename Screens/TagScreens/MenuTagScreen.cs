namespace Blog.Screens.TagScreens;

public static class MenuTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Tag Management");
        Console.WriteLine("---------------");
        Console.WriteLine("Choose a option:");
        Console.WriteLine();
        Console.WriteLine("1 - List tags");
        Console.WriteLine("2 - Create a new tag");
        Console.WriteLine("3 - Update a existent tag");
        Console.WriteLine("4 - Delete a tag");
        Console.WriteLine("5 - Back to Main Menu");

        Console.WriteLine();
        Console.WriteLine();

        short.TryParse(Console.ReadLine(), out short option);

        switch (option)
        {
            case 1:
                ListTagScreen.Load();
                break;
            case 2:
                CreateTagScreen.Load();
                break;
            case 3:
                UpdateTagScreen.Load();
                break;
            case 4:
                DeleteTagScreen.Load();
                break;
            case 5:
                MainScreen.Load();
                break;
            default: Load(); break;
        }
    }
}