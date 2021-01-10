using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stanciu_Madalina_Proiect_Medii.Models;

namespace Stanciu_Madalina_Proiect_Medii.Data
{
    public class Stanciu_Madalina_Proiect_MediiContext : DbContext
    {
        public Stanciu_Madalina_Proiect_MediiContext (DbContextOptions<Stanciu_Madalina_Proiect_MediiContext> options)
            : base(options)
        {
        }

        public DbSet<Stanciu_Madalina_Proiect_Medii.Models.Product> Product { get; set; }

        public DbSet<Stanciu_Madalina_Proiect_Medii.Models.Producer> Producer { get; set; }

        public DbSet<Stanciu_Madalina_Proiect_Medii.Models.Category> Category { get; set; }

        public DbSet<Stanciu_Madalina_Proiect_Medii.Models.ProductCategory> ProductCategory { get; set; }
    }
}
