using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Domain.Entities.FactTables;
using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using CuttingDownIncidents.Domain.Entities.FactTables.Network;
using CuttingDownIncidents.Domain.Entities.Staging_Tables;
using CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
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




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
