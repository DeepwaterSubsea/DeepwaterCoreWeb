using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RigOriginalEquipmentManufacturer> RigOEMs { get; set; }
        public DbSet<RigOperator> RigOperators { get; set; }
        public DbSet<RigContractor> RigContractors { get; set; }
        public DbSet<Rig> Rigs { get; set; }
        public DbSet<RigAsset> RigAssets { get; set; }
        public DbSet<Well> Wells { get; set; }
        public DbSet<StatusInformation> StatusInformation { get; set; }
        public DbSet<RigWellOperatorRecord> RigWellOperatorRecords { get; set; }
    }

}
