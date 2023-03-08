using FitnessEquipment.Domain.Weights.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessEquipment.Domain.WeightsTypes.Models
{
    public class WeightType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<WeightItem> WeightItems { get; set; }
    }
}
