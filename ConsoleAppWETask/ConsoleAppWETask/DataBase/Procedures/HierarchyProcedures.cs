using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.DataBase.Procedures
{
    public static class HierarchyProcedures
    {

        public static async Task GetParentHierarchyAsync(this ApplicationDbContext context, int elementKey)
        {
            await context.Database.ExecuteSqlRawAsync("EXEC GetParentHierarchy {0}", elementKey);
        }

        public static async Task BuildNetworkElementHierarchyAsync(this ApplicationDbContext context, int elementKey)
        {
            await context.Database.ExecuteSqlRawAsync("EXEC BuildNetworkElementHierarchy {0}", elementKey);
        }
        public static async Task GetFirstLevelChildrenAsync(this ApplicationDbContext context, int elementKey)
        {
            await context.Database.ExecuteSqlRawAsync("EXEC GetFirstLevelChildren {0}", elementKey);
        }
    }
}
