using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stanciu_Madalina_Proiect_Medii.Data;
using Stanciu_Madalina_Proiect_Medii.Models;

namespace Stanciu_Madalina_Proiect_Medii.Pages.Products
{
    public class EditModel : ProductCategoryPageModel
    {
        private readonly Stanciu_Madalina_Proiect_Medii.Data.Stanciu_Madalina_Proiect_MediiContext _context;

        public EditModel(Stanciu_Madalina_Proiect_Medii.Data.Stanciu_Madalina_Proiect_MediiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(b => b.Producer)
                .Include(b => b.ProductCategories).ThenInclude(b => b.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Product == null)
            {
                return NotFound();
            }
          
            PopulateAssignedCategoryData(_context, Product);
            ViewData["ProducerID"] = new SelectList(_context.Producer, "ID", "ProducerName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, string[] selectedCategories)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productToUpdate = await _context.Product
                .Include(i => i.Producer)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefaultAsync(s => s.ID == id);
            if (productToUpdate == null)
            {
                return NotFound();
            }
            if (await TryUpdateModelAsync<Product>(
                productToUpdate,
                    "Product",
                    i => i.Name, i => i.Description,
                    i => i.Price, i => i.ProducerID))
            {
                UpdateProductCategories(_context, selectedCategories, productToUpdate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            UpdateProductCategories(_context, selectedCategories, productToUpdate);
            PopulateAssignedCategoryData(_context, productToUpdate);
            return Page();
        }
    }
}
