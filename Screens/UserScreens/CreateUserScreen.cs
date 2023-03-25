using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public static class CreateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Create user");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Email:");
        string email = Console.ReadLine();

        Console.WriteLine("Password:");
        string passwordHash = Console.ReadLine();

        Console.WriteLine("Bio:");
        string bio = Console.ReadLine();

        Console.WriteLine("Img Link:");
        string image = Console.ReadLine();

        Console.WriteLine("Slug");
        string slug = Console.ReadLine();

        Create(new User
        {
            Name = name,
            Email = email,
            PasswordHash = passwordHash,
            Bio = bio,
            Image = image,
            Slug = slug,
        });

        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Create(user);
            Console.WriteLine("User created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while creating a user");
            Console.WriteLine(ex.Message);
        }
    }
}