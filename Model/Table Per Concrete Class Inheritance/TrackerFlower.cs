using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Table_Per_Concrete_Class_Inheritance
{
    public abstract class TrackerFlower
    {
        [Key, Column(Order = 0)]
        public int FlowerId { get; set; }
        public virtual Flower Flower { get; set; }

        [Required, Range(1, System.Int32.MaxValue, ErrorMessage = "The Amount dosen't be negative value.")]
        public int Amount { get; set; }
    }
}
