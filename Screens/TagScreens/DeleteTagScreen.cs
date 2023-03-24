using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class DeleteTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Delete tag");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("What your Tag ID?");
        var id = short.Parse(Console.ReadLine());

        Delete(id);

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Tag deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while deleting a tag");
            Console.WriteLine(ex.Message);
        }
    }
}