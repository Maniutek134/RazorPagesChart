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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public DetailsModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

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
    }
}
