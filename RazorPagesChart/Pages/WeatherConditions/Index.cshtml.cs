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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesChart.Model.DataBaseGdyniaContext _context;

        public IndexModel(RazorPagesChart.Model.DataBaseGdyniaContext context)
        {
            _context = context;
        }

        public IList<WeatherCondition> WeatherCondition { get;set; }

        public async Task OnGetAsync()
        {
            WeatherCondition = await _context.WeatherCondition.ToListAsync();
        }
    }
}
