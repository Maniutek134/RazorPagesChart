using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesChart.Model;

namespace RazorPagesChart.Pages.AverageIntensities
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public DeleteModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AverageIntensity AverageIntensity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AverageIntensity = await _context.AverageIntensity.FirstOrDefaultAsync(m => m.Id == id);

            if (AverageIntensity == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AverageIntensity = await _context.AverageIntensity.FindAsync(id);

            if (AverageIntensity != null)
            {
                _context.AverageIntensity.Remove(AverageIntensity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
