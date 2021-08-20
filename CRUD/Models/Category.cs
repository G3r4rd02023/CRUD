using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(30, ErrorMessage =
            "El Campo {0} puede contener {1} y minimo {2} caracteres",
            MinimumLength = 3)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}