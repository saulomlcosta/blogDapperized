using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class CreateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Create tag");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Whats is your tag name?");
        string name = Console.ReadLine();

        Console.WriteLine("Whats is your slug name?");
        string slug = Console.ReadLine();

        Create(new Tag
        {
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Create(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Create(tag);
            Console.WriteLine("Tag created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while creating a tag");
            Console.WriteLine(ex.Message);
        }
    }
}