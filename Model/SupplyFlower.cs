using Model.Table_Per_Concrete_Class_Inheritance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SupplyFlower : TrackerFlower
    {
        [Key, Column(Order = 0)]
        public int SupplyId { get; set; }
        public virtual Supply Supply { get; set; }
    }
}
