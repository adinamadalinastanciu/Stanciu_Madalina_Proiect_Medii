using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stanciu_Madalina_Proiect_Medii.Data;
using Stanciu_Madalina_Proiect_Medii.Models;

namespace Stanciu_Madalina_Proiect_Medii.Pages.Producers
{
    public class IndexModel : PageModel
    {
        private readonly Stanciu_Madalina_Proiect_Medii.Data.Stanciu_Madalina_Proiect_MediiContext _context;

        public IndexModel(Stanciu_Madalina_Proiect_Medii.Data.Stanciu_Madalina_Proiect_MediiContext context)
        {
            _context = context;
        }

        public IList<Producer> Producer { get;set; }

        public async Task OnGetAsync()
        {
            Producer = await _context.Producer.ToListAsync();
        }
    }
}
