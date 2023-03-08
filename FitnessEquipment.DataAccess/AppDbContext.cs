using FitnessEquipment.DataAccess.Builders.Weights;
using FitnessEquipment.DataAccess.Builders.WeightsTypes;
using FitnessEquipment.Domain.Weights.Models;
using FitnessEquipment.Domain.WeightsTypes.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessEquipment.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<WeightItem> WeightItems { get; set; }

        public DbSet<WeightType> WeightTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            WeightItemsBuilder.Build(modelBuilder);
            WeightTypeBuilder.Build(modelBuilder);
        }
    }
}
