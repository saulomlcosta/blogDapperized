using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public static class DeleteUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Update user");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("ID:");
        int id = int.Parse(Console.ReadLine());

        Delete(id);

        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("User deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while deleting a user");
            Console.WriteLine(ex.Message);
        }
    }
}