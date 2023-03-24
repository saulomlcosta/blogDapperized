namespace Blog.Screens.RoleScreens;

public static class MenuRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Profile Management");
        Console.WriteLine("---------------");
        Console.WriteLine("Choose a option:");
        Console.WriteLine();
        Console.WriteLine("1 - List roles");
        Console.WriteLine("2 - Create a new role");
        Console.WriteLine("3 - Update a existent role");
        Console.WriteLine("4 - Delete a role");
        Console.WriteLine("5 - Back to Main Menu");

        Console.WriteLine();
        Console.WriteLine();

        short.TryParse(Console.ReadLine(), out short option);

        switch (option)
        {
            case 1:
                ListRoleScreen.Load();
                break;
            case 2:
                CreateRoleScreen.Load();
                break;
            case 3:
                UpdateRoleScreen.Load();
                break;
            case 4:
                DeleteRoleScreen.Load();
                break;
            case 5:
                MainScreen.Load();
                break;
            default: Load(); break;
        }
    }
}