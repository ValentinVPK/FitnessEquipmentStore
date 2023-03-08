using FitnessEquipment.Domain.Weights.Models;
using FitnessEquipment.Domain.WeightsTypes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessEquipment.DataAccess.Builders.Weights
{
    static public class WeightItemsBuilder
    {
        public static void Build(ModelBuilder builder)
        {
            builder.Entity<WeightItem>(weightItem =>
            {
                weightItem.HasKey(w => w.Id);
                weightItem.Property(w => w.Name).HasMaxLength(500).IsRequired();
                weightItem.Property(w => w.Description);
                weightItem.Property(w => w.Kgs).HasColumnType("decimal(6, 2)").IsRequired();
                weightItem.Property(w => w.Image);
                weightItem.Property(w => w.Materials)
                    .HasConversion(w => w.ToString(), w => (EnumWeightMaterials)Enum.Parse(typeof(EnumWeightMaterials), w))
                    .IsRequired();
                weightItem.HasOne(wt => wt.Type)
                    .WithMany(wt => wt.WeightItems)
                    .HasForeignKey(w => w.WeightTypeId);
            });

        }
    }
}
