using ConsoleAppWETask.Entities.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWETask.DataBase
{
 public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public DbSet<CuttingDownDetail> Cutting_Down_Detail { get; set; }
        public DbSet<CuttingDownHeader> Cutting_Down_Header { get; set; }
        public DbSet<CuttingDownIgnored> Cutting_Down_Ignored { get; set; }
        public DbSet<Governrate> Governrate { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Tower> Tower { get; set; }
        public DbSet<Cabin> Cabin { get; set; }
        public DbSet<Cable> Cable { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Flat> Flat { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<ProblemType> Problem_Type { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<CuttingDownA> Cutting_Down_A{ get; set; }
        public DbSet<CuttingDownB> Cutting_Down_B { get; set; }
        public DbSet<NetworkElementHierarchyPath> Network_Element_Hierarchy_Path { get; set; }
        public DbSet<NetworkElementType> Network_Element_Type { get; set; }
        public DbSet<NetworkElement> Network_Element { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();
            var constr = configuration.GetSection("DefaultConnection").Value;
            optionsBuilder.UseSqlServer(constr);
        }

        


        public async Task ExecuteSpCreateAsync(CuttingDownForm form)
        {
            await Database.ExecuteSqlRawAsync(@"
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

        // 🔹 Execute sp_Close
        public async Task ExecuteSpCloseAsync(CuttingDownForm form)
        {
            await Database.ExecuteSqlRawAsync(@"
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
   

