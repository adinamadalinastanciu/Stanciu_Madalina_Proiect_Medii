using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stanciu_Madalina_Proiect_Medii.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public Product Product { get; set; }
    }
}
