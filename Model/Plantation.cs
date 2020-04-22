using Model.Table_Per_Concrete_Class_Inheritance;
using System.Collections.Generic;

namespace Model
{
    public class Plantation : Place
    {
        public ICollection<Supply> Supplies { get; set; }
        public ICollection<PlantationFlower> PlantationFlowers { get; set; }
    }
}
