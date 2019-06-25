using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesChart.Model;

namespace RazorPagesChart.Pages.WeatherConditions
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public CreateModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WeatherCondition WeatherCondition { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WeatherCondition.Add(WeatherCondition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}