using ConsoleAppWETask;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWETask
{
public class Program
{
    
    public static void Main(string[] args)
    {
       using(var context = new ApplicationDbContext())
        {
                foreach (var item in context.Governrate) {
                

                    Console.WriteLine(item);
                }
        }
        Console.ReadKey();  
    }
}
}
