using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stanciu_Madalina_Proiect_Medii.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1, 300)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
       
        public int ProducerID { get; set; }
        public Producer Producer { get; set; }
        public int ProductCategoryID { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
