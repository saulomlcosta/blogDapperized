using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class UpdateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Update profile");
        Console.WriteLine("---------------");
        Console.WriteLine();

        Console.WriteLine("ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Slug");
        string slug = Console.ReadLine();

        Update(new Role
        {
            Id = id,
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Update(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Update(role);
            Console.WriteLine("Profile updated successfully");
        }
        catch (Exception ex)
        {

            Console.WriteLine("An error occurred while updating a profile");
            Console.WriteLine(ex.Message);
        }
    }
}