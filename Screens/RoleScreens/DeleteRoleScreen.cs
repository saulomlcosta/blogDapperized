using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class DeleteRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Delete profile");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("ID:");
        int id = int.Parse(Console.ReadLine());

        Delete(id);

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Profile deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while deleting a profile");
            Console.WriteLine(ex.Message);
        }
    }
}