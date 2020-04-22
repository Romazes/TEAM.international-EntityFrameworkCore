using System.ComponentModel.DataAnnotations;

namespace Model.Table_Per_Concrete_Class_Inheritance
{
    public abstract class Place : BaseEntity
    {
        [Required(ErrorMessage = "The Name is required.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Address is required.")]
        [MaxLength(200)]
        public string Address { get; set; }
    }
}
