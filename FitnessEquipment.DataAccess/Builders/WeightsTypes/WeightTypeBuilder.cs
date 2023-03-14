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

                weightType.HasData(
                    new WeightType { Id = 1, Name = "Dumbells", Description = "Dumbbells are a highly effective tool for building strength and muscle mass due to their versatility and ability to target specific muscle groups. They offer a greater range of motion than other weight training equipment, allowing for more muscle fibers to be engaged during exercises. Additionally, their adjustable weight feature allows for easy progression as strength increases, making them a great choice for both beginners and experienced lifters." },
                    new WeightType { Id = 2, Name = "Kettlebells" , Description = "Kettlebells are an effective tool for building strength, endurance, and flexibility due to their unique shape and design. They allow for a wide range of dynamic movements that engage multiple muscle groups simultaneously, improving overall fitness and coordination. Kettlebells are also highly versatile and can be used for a variety of exercises, including swings, snatches, and Turkish get-ups, making them an excellent choice for anyone looking to challenge their body and take their workouts to the next level." },
                    new WeightType { Id = 3, Name = "Plates" , Description = "Weight plates are circular metal discs that are used to add resistance to a barbell, dumbbell, or weight machine. They come in a variety of sizes and weights, allowing users to gradually increase resistance levels as their strength improves, making them a versatile and essential tool in strength training and fitness programs." },
                    new WeightType { Id = 4, Name = "Barbells" , Description = "Training with barbells is highly effective for building strength and muscle mass due to their ability to provide heavy resistance and target multiple muscle groups simultaneously. Barbells allow for a variety of compound exercises, such as squats, deadlifts, and bench press, which engage a large number of muscle fibers and promote overall growth and development. Additionally, their ability to progressively overload allows for continued gains in strength and muscle size, making them a staple in many strength training programs." }
                );
            });
        }
    }
}
