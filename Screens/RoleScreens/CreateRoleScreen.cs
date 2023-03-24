using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class CreateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Create profile");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Slug");
        string slug = Console.ReadLine();

        Create(new Role
        {
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Create(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Create(role);
            Console.WriteLine("Profile created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while creating a profile");
            Console.WriteLine(ex.Message);
        }
    }
}