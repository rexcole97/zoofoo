using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;
using WebApplication1.Data.zookeeper;

namespace WebApplication1.Pages.ZooKeepers
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Data.ApplicationDbContext _context;

        public CreateModel(WebApplication1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public zkeeper zkeeper { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.zkeeper.Add(zkeeper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
