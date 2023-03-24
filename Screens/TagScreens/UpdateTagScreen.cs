using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class UpdateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Update tag");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Whats is Tag ID?");
        string id = Console.ReadLine();
        Console.WriteLine("Whats is your tag name?");
        string name = Console.ReadLine();
        Console.WriteLine("Whats is your slug name?");
        string slug = Console.ReadLine();

        Update(new Tag
        {
            Id = int.Parse(id),
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Update(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            Console.WriteLine("Tag updated successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while update a tag");
            Console.WriteLine(ex.Message);
        }
    }
}