namespace Blog.Screens.UserScreens;

public static class MenuUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("User Management");
        Console.WriteLine("---------------");
        Console.WriteLine("Choose a option:");
        Console.WriteLine();
        Console.WriteLine("1 - List users");
        Console.WriteLine("2 - Create a new user");
        Console.WriteLine("3 - Update a existent user");
        Console.WriteLine("4 - Delete a user");
        Console.WriteLine("5 - Back to Main Menu");

        Console.WriteLine();
        Console.WriteLine();

        short.TryParse(Console.ReadLine(), out short option);

        switch (option)
        {
            case 1:
                ListUserScreen.Load();
                break;
            case 2:
                CreateUserScreen.Load();
                break;
            case 3:
                UpdateUserScreen.Load();
                break;
            case 4:
                DeleteUserScreen.Load();
                break;
            case 5:
                MainScreen.Load();
                break;
            default: Load(); break;
        }
    }
}