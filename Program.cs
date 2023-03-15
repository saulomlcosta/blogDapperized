// See https://aka.ms/new-console-template for more information

using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = "Server=localhost,1450; Database=Blog; User ID=SA;Password= Numsey#2022; TrustServerCertificate=True;";

var connection = new SqlConnection(CONNECTION_STRING);

connection.Open();
ReadUsers(connection);
ReadRoles(connection);
ReadTags(connection);
connection.Close();

Console.ReadKey();

static void ReadUsers(SqlConnection connection)
{
    var repository = new Repository<User>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}
static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}


