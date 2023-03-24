using Blog;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;


public static class UpdateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Update user");
        Console.WriteLine("---------------");
        Console.WriteLine();

        Console.WriteLine("ID:");
        int id = int.Parse(Console.ReadLine());

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

        Update(new User
        {
            Id = id,
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

    public static void Update(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Update(user);
            Console.WriteLine("User updated successfully");
        }
        catch (Exception ex)
        {

            Console.WriteLine("An error occurred while updating a user");
            Console.WriteLine(ex.Message);
        }
    }
}