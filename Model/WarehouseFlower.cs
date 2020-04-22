using Model.Table_Per_Concrete_Class_Inheritance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class WarehouseFlower : TrackerFlower
    {
        [Key, Column(Order = 0)]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
