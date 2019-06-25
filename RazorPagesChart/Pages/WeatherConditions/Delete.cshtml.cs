using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesChart.Model;

namespace RazorPagesChart.Pages.WeatherConditions
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public DeleteModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WeatherCondition WeatherCondition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WeatherCondition = await _context.WeatherCondition.FirstOrDefaultAsync(m => m.Id == id);

            if (WeatherCondition == null)
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

            WeatherCondition = await _context.WeatherCondition.FindAsync(id);

            if (WeatherCondition != null)
            {
                _context.WeatherCondition.Remove(WeatherCondition);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
