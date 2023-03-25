using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;

namespace Blog.Screens;

public static class ReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Reports Screen");
        Console.WriteLine("---------------");
        Console.WriteLine("Choose a option:");
        Console.WriteLine();
        Console.WriteLine("1 - Users with their roles");
        Console.WriteLine("5 - Back to Main Screen");
        Console.WriteLine();
        Console.WriteLine();

        short.TryParse(Console.ReadLine(), out short option);

        Console.Clear();

        switch (option)
        {
            case 1:
                ListUserScreen.ListWithRoles();
                break;
            case 5:
                MainScreen.Load();
                break;
            default: Load(); break;
        }

        Console.ReadKey();

        Load();
    }
}