using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.DataBase.Functions
{
    public static class ImpactFunctions
    {
        public static async Task<int> GetTotalImpactedCustomersAsync(this ApplicationDbContext context, int elementKey)
        {
            // Execute SQL that returns a scalar and fetch first value
            var result = await context.Database
                .SqlQuery<int>($"SELECT dbo.GetTotalImpactedCustomers({elementKey})")
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
