using ConsoleAppWETask.Entities.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.DataBase.Procedures
{
    public static class CuttingDownProcedures
    {
        public static async Task ExecuteSpCreateAsync(this ApplicationDbContext context, CuttingDownForm form)
        {
            await context.Database.ExecuteSqlRawAsync(@"
                EXEC dbo.sp_Create 
                    @SourceType = {0}, 
                    @Cutting_Down_Cabin_Name = {1}, 
                    @Cutting_Down_Cable_Name = {2}, 
                    @Problem_Type_Key = {3}, 
                    @CreateDate = {4}, 
                    @EndDate = {5}, 
                    @IsPlanned = {6}, 
                    @IsGlobal = {7}, 
                    @PlannedStartDTS = {8}, 
                    @PlannedEndDTS = {9}, 
                    @IsActive = {10}, 
                    @CreatedUser = {11}, 
                    @UpdatedUser = {12}, 
                    @Network_Element_Key = {13}, 
                    @ImpactedCustomers = {14}",
                form.SourceType,
                form.CabinName,
                form.CableName,
                form.ProblemTypeKey,
                form.CreateDate,
                form.EndDate,
                form.IsPlanned,
                form.IsGlobal,
                form.PlannedStartDTS,
                form.PlannedEndDTS,
                form.IsActive,
                form.CreatedUser,
                form.UpdatedUser,
                form.NetworkElementKey,
                form.ImpactedCustomers
            );
        }

        public static async Task ExecuteSpCloseAsync(this ApplicationDbContext context, CuttingDownForm form)
        {
            await context.Database.ExecuteSqlRawAsync(@"
                EXEC dbo.sp_Close 
                    @SourceType = {0}, 
                    @Cutting_Down_Cabin_Name = {1}, 
                    @Cutting_Down_Cable_Name = {2}, 
                    @Problem_Type_Key = {3}, 
                    @CreateDate = {4}, 
                    @EndDate = {5}, 
                    @IsPlanned = {6}, 
                    @IsGlobal = {7}, 
                    @PlannedStartDTS = {8}, 
                    @PlannedEndDTS = {9}, 
                    @IsActive = {10}, 
                    @CreatedUser = {11}, 
                    @UpdatedUser = {12}, 
                    @Network_Element_Key = {13}, 
                    @ImpactedCustomers = {14}",
                form.SourceType,
                form.CabinName,
                form.CableName,
                form.ProblemTypeKey,
                form.CreateDate,
                form.EndDate,
                form.IsPlanned,
                form.IsGlobal,
                form.PlannedStartDTS,
                form.PlannedEndDTS,
                form.IsActive,
                form.CreatedUser,
                form.UpdatedUser,
                form.NetworkElementKey,
                form.ImpactedCustomers
            );
        }
    }
}
