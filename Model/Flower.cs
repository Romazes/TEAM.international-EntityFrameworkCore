using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Flower : BaseEntity
    {
        [MaxLength(50), Required(ErrorMessage = "The Name is required.")]
        public string Name { get; set; }
        [StringLength(50)]
        public string LatinName { get; set; }

        public ICollection<PlantationFlower> PlantationFlowers { get; set; }
        public ICollection<WarehouseFlower> WarehouseFlowers { get; set; }
        public ICollection<SupplyFlower> SupplyFlowers { get; set; }
    }
}
