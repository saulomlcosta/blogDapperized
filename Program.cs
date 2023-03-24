using Blog;
using Blog.Screens;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = "Server=localhost,1450; Database=Blog; User ID=SA;Password= Numsey#2022; TrustServerCertificate=True;";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

MainScreen.Load();

Console.ReadKey();
Database.Connection.Close();




