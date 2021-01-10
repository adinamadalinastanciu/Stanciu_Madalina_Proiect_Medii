using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stanciu_Madalina_Proiect_Medii.Models
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
