using ConsoleApp1;
using System.Data;
using System.Data.SqlClient;


internal class Program
{

    private static void Main(string[] args)
    {
        var start = new ProgramStart();
        start.Start();
        Console.Read();
    }
}