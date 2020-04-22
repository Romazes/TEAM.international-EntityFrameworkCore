using Model.Table_Per_Concrete_Class_Inheritance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class PlantationFlower : TrackerFlower
    {
        [Key, Column(Order = 1)]
        public int PlantationId { get; set; }
        public Plantation Plantation { get; set; }
    }
}
