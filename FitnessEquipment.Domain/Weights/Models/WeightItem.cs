using FitnessEquipment.Domain.WeightsTypes.Models;

namespace FitnessEquipment.Domain.Weights.Models
{
    public class WeightItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public int WeightTypeId { get; set; }

        public WeightType Type { get; set; }

        public double Kgs { get; set; }

        public double Price { get; set; }

        public EnumWeightMaterials Materials { get; set; }

        public string? ImagePath { get; set; }
    }
}
