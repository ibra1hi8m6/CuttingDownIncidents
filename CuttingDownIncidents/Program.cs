using ConsoleAppWETask;
using ConsoleAppWETask.DataBase;
using ConsoleAppWETask.DataBase.Functions;
using ConsoleAppWETask.DataBase.Procedures;
using ConsoleAppWETask.Input;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWETask
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1 - Enter Cutting_Down_Open (sp_Create)");
                Console.WriteLine("2 - Enter Cutting_Down_Close (sp_Close)");
                string choice = Console.ReadLine();

                var form = InputHelper.GetUserInput();

                using (var context = new ApplicationDbContext())
                {
                    switch (choice)
                    {
                        case "1":
                            await context.ExecuteSpCreateAsync(form);
                            Console.WriteLine("sp_Create executed successfully.");
                            break;

                        case "2":
                            await context.ExecuteSpCloseAsync(form);
                            Console.WriteLine("sp_Close executed successfully.");
                            break;
                        case "3":
                            Console.Write("Enter NetworkElementKey: ");
                            int key1 = int.Parse(Console.ReadLine());
                            int totalCustomers = await context.GetTotalImpactedCustomersAsync(key1);
                            Console.WriteLine($"Total impacted customers: {totalCustomers}");
                            break;

                        case "4":
                            Console.Write("Enter NetworkElementKey: ");
                            int key2 = int.Parse(Console.ReadLine());
                            await context.GetParentHierarchyAsync(key2);
                            Console.WriteLine("GetParentHierarchy executed successfully.");
                            break;

                        case "5":
                            Console.Write("Enter NetworkElementKey: ");
                            int key3 = int.Parse(Console.ReadLine());
                            await context.GetFirstLevelChildrenAsync(key3);
                            Console.WriteLine("GetFirstLevelChildren executed successfully.");
                            break;

                        case "6":
                            Console.Write("Enter NetworkElementKey: ");
                            int key4 = int.Parse(Console.ReadLine());
                            await context.BuildNetworkElementHierarchyAsync(key4);
                            Console.WriteLine("BuildNetworkElementHierarchy executed successfully.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }

                Console.ReadKey();
            }
        }
    }

}