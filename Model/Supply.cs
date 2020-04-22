using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Supply : BaseEntity
    {
        [Display(Name = "Scheduled Date")]
        public DateTime ScheduledDate { get; set; }
        [Display(Name = "Date closed")]
        public DateTime ClosedDate { get; set; }
        public string Status { get; set; }

        public int PlantationId { get; set; }
        public Plantation Plantation { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<SupplyFlower> SupplyFlowers { get; set; }
    }
}
