using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage =
            "El Campo {0} puede contener {1} y minimo {2} caracteres",
            MinimumLength = 3)]
        [Display(Name = "Producto")]      
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido!")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio")]
        [Range(0, double.MaxValue, ErrorMessage = "Debe elegir un {0} entre {1} y {2}")]
        public decimal Price { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}