using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesChart.Model;

namespace RazorPagesChart.Pages.Intensities
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public DeleteModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Intensity Intensity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Intensity = await _context.Intensity
                .Include(i => i.DbTemperature).FirstOrDefaultAsync(m => m.Id == id);

            if (Intensity == null)
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

            Intensity = await _context.Intensity.FindAsync(id);

            if (Intensity != null)
            {
                _context.Intensity.Remove(Intensity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
