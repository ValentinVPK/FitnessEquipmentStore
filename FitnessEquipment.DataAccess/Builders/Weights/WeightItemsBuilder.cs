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
                weightItem.Property(w => w.ImagePath);
                weightItem.Property(w => w.Price).HasColumnType("decimal(6,2)").IsRequired();
                weightItem.Property(w => w.Materials)
                    .HasConversion(w => w.ToString(), w => (EnumWeightMaterials)Enum.Parse(typeof(EnumWeightMaterials), w))
                    .IsRequired();
                weightItem.HasOne(wt => wt.Type)
                    .WithMany(wt => wt.WeightItems)
                    .HasForeignKey(w => w.WeightTypeId);

                weightItem.HasData(
                    new WeightItem { Id = 1, Name = "Dumbells Hex Pro", Description = "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", WeightTypeId = 1, Kgs = 32.5, Price = 250, Materials = EnumWeightMaterials.SteelAndRubber },
                    new WeightItem { Id = 2, Name = "Dumbells TPU Series", Description = "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", WeightTypeId = 1, Kgs = 10, Price = 90, Materials = EnumWeightMaterials.SteelAndRubber },
                    new WeightItem { Id = 3, Name = "Adjustable dumbells", Description = "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", WeightTypeId = 1, Kgs = 15, Price = 120, Materials = EnumWeightMaterials.CastIron },
                    new WeightItem { Id = 4, Name = "Russian Kettlebell", Description = "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", WeightTypeId = 2, Kgs = 40, Price = 250, Materials = EnumWeightMaterials.Steel },
                    new WeightItem { Id = 5, Name = "HQ Competition Kettlebell", Description = "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", WeightTypeId = 2, Kgs = 16, Price = 90, Materials = EnumWeightMaterials.Steel },
                    new WeightItem { Id = 6, Name = "Vinyl Kettlebell", Description = "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", WeightTypeId = 2, Kgs = 8, Price = 40, Materials = EnumWeightMaterials.SteelAndRubber },
                    new WeightItem { Id = 7, Name = "ATX Bumper Plates", Description = "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", WeightTypeId = 3, Kgs = 10, Price = 200, Materials = EnumWeightMaterials.Steel },
                    new WeightItem { Id = 8, Name = "ATX Color Splash Plates", Description = "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", WeightTypeId = 3, Kgs = 20, Price = 150, Materials = EnumWeightMaterials.Rubber },
                    new WeightItem { Id = 9, Name = "ATX Fractional Plates", Description = "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", WeightTypeId = 3, Kgs = 2, Price = 50, Materials = EnumWeightMaterials.Steel },
                    new WeightItem { Id = 10, Name = "ATX – XTP Raw Powerlifting Bar", Description = "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", WeightTypeId = 4, Kgs = 20, Price = 700, Materials = EnumWeightMaterials.CastIron },
                    new WeightItem { Id = 11, Name = "ATX Trap Bar XL", Description = "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", WeightTypeId = 4, Kgs = 25, Price = 300, Materials = EnumWeightMaterials.Steel },
                    new WeightItem { Id = 12, Name = "Curl SZ PRO Bar ATX", Description = "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", WeightTypeId = 4, Kgs = 12, Price = 150, Materials = EnumWeightMaterials.CastIron }
                );
            });

        }
    }
}
