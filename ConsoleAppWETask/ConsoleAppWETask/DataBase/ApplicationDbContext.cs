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

        public ApplicationDbContext() { }
    }
}
   

