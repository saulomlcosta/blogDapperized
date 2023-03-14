// See https://aka.ms/new-console-template for more information

using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = "Server=localhost,1450; Database=Blog; User ID=SA;Password= Numsey#2022; TrustServerCertificate=True;";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();
// ReadUser();
// ReadUsers(connection);
// CreateUser(connection);
// UpdateUser();
// DeleteUser();
connection.Close();

Console.ReadKey();

static void ReadUsers(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var users = repository.Get();

    foreach (var user in users)
        Console.WriteLine(user.Name);
}

static void ReadUser(SqlConnection connection, int id)
{
    var repository = new UserRepository(connection);
    var user = repository.Get(id);

    Console.WriteLine(user.Name);
}

// static void CreateUser(SqlConnection connection)
// {
//     var repository = new UserRepository(connection);

//     var user = new User
//     {
//         Name = "André Lima",
//         Email = "andre@gmail.com",
//         Image = "https://images",
//         PasswordHash = "password",
//         Slug = "andre-lima",
//         Bio = "Minha bio"
//     };

//     repository.Create(user);
//     Console.WriteLine("User created successfully");
// }

// static void UpdateUser()
// {
//     using (var connection = new SqlConnection(connectionString))
//     {
//         var user = new User
//         {
//             Id = 1,
//             Name = "Saulo Lima",
//             Email = "saulo@gmail.com",
//             Image = "https://images",
//             PasswordHash = "password",
//             Slug = "saulo-lima",
//             Bio = "Minha bio"
//         };

//         connection.Update(user);
//         Console.WriteLine("User updated successfully");
//     }
// }


// static void DeleteUser()
// {
//     using (var connection = new SqlConnection(connectionString))
//     {
//         var user = connection.Get<User>(2);
//         connection.Delete(user);
//         Console.WriteLine("User deleted successfully");
//     }
// }