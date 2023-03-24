using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;

namespace Blog.Screens;

public static class MainScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Blog");
        Console.WriteLine("---------------");
        Console.WriteLine("What you want to do?");
        Console.WriteLine();
        Console.WriteLine("1 - User Management");
        Console.WriteLine("2 - Profile Management");
        Console.WriteLine("3 - Category Management");
        Console.WriteLine("4 - Tag Management");
        Console.WriteLine("5 - Post/User");
        Console.WriteLine("6 - Post/Tag");
        Console.WriteLine("7 - Reports");
        Console.WriteLine("8 - Exit");
        Console.WriteLine();
        Console.WriteLine();

        short.TryParse(Console.ReadLine(), out short option);

        switch (option)
        {
            case 1:
                MenuUserScreen.Load();
                break;
            case 2:
                MenuRoleScreen.Load();
                break;
            case 4:
                MenuTagScreen.Load();
                break;
            case 8:
                Environment.Exit(0);
                break;
            default: Load(); break;
        }
    }
}