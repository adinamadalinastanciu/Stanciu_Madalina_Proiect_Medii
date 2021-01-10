using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stanciu_Madalina_Proiect_Medii.Models
{
    public class ProductData
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
