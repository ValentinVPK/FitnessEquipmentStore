using FitnessEquipment.Domain.WeightsTypes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessEquipment.DataAccess.Builders.WeightsTypes
{
    public static class WeightTypeBuilder
    {
        public static void Build(ModelBuilder builder)
        {
            builder.Entity<WeightType>(weightType =>
            {
                weightType.HasKey(wt => wt.Id);
                weightType.Property(wt => wt.Name).HasMaxLength(500).IsRequired();
                weightType.Property(wt => wt.Description);
            });
        }
    }
}
