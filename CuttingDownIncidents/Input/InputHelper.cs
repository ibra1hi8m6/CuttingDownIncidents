using ConsoleAppWETask.Entities.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.Input
{
    public class InputHelper
    {
        public static CuttingDownForm GetUserInput()
        {
            var form = new CuttingDownForm();

            Console.Write("Enter SourceType (A/B): ");
            form.SourceType = Console.ReadLine();

            Console.Write("Enter Cabin Name: ");
            form.CabinName = Console.ReadLine();

            Console.Write("Enter Cable Name: ");
            form.CableName = Console.ReadLine();

            Console.Write("Enter ProblemTypeKey: ");
            form.ProblemTypeKey = int.Parse(Console.ReadLine());

            Console.Write("Enter EndDate (yyyy-MM-dd or leave blank): ");
            string endDate = Console.ReadLine();
            form.EndDate = string.IsNullOrWhiteSpace(endDate) ? null : DateTime.Parse(endDate);

            Console.Write("Is Planned? (true/false): ");
            form.IsPlanned = bool.Parse(Console.ReadLine());

            Console.Write("Is Global? (true/false): ");
            form.IsGlobal = bool.Parse(Console.ReadLine());

            Console.Write("Enter CreatedUser: ");
            form.CreatedUser = Console.ReadLine();

            Console.Write("Enter NetworkElementKey (or leave blank): ");
            string netKey = Console.ReadLine();
            form.NetworkElementKey = string.IsNullOrWhiteSpace(netKey) ? null : int.Parse(netKey);

            Console.Write("Enter ImpactedCustomers: ");
            form.ImpactedCustomers = int.Parse(Console.ReadLine());

            return form;
        }
    }
}
