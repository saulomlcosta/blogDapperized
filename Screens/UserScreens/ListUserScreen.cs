using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;


public static class ListUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("User List");
        Console.WriteLine("---------------");
        Console.WriteLine();
        List();
        Console.ReadKey();

        MenuUserScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<User>(Database.Connection);
        var users = repository.Get();
        foreach (var item in users)
        {
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
        }
    }

    public static void ListWithRoles()
    {
        var repository = new UserRepository(Database.Connection);
        var users = repository.GetWithRoles();
        foreach (var item in users)
        {
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Email}");
            foreach (var role in item.Roles)
                Console.WriteLine($"- {role.Name}");
        }
    }
}