using Model.Table_Per_Concrete_Class_Inheritance;
using System.Collections.Generic;

namespace Model
{
    public class Warehouse : Place
    {
        public ICollection<Supply> Supplies { get; set; }
        public ICollection<WarehouseFlower> WarehouseFlowers { get; set; }
    }
}
