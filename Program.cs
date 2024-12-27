// See https://aka.ms/new-console-template for more information
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

IDbConnection dbConnection = new SqlConnection(connectionString);

string sqlCommand = "SELECT GETDATE()";

DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

System.Console.WriteLine(rightNow);