// See https://aka.ms/new-console-template for more information
using System.Data;
using Dapper;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

IDbConnection dbConnection = new SqlConnection(connectionString);

string sqlCommand = "SELECT GETDATE()";

DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

System.Console.WriteLine(rightNow.ToString(""));

Computer myComputer = new Computer() {
    Motherboard = "Z600",
    HasWifi =  true,
    HasLTE = true,
    ReleaseDate = DateTime.Now,
    Price = 7765.4m,
    VideoCard = "RTX 2060",
};

string sql = @"INSERT INTO TutorialAppSchema.Computer (
    Motherboard,
    HasWifi,
    HasLTE,
    ReleaseDate,
    Price,
    VideoCard
) VALUES (
    '" + myComputer.Motherboard 
    + "','" + myComputer.HasWifi
    + "','" + myComputer.HasLTE
    + "','" + myComputer.ReleaseDate
    + "','" + myComputer.Price
    + "','" + myComputer.VideoCard

+ "')";

Console.WriteLine(sql);
int result = dbConnection.Execute(sql);
Console.WriteLine(result);