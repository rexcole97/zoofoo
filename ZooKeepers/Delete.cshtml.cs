using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.zookeeper;

namespace WebApplication1.Pages.ZooKeepers
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.Data.ApplicationDbContext _context;

        public DeleteModel(WebApplication1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public zkeeper zkeeper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            zkeeper = await _context.zkeeper.FirstOrDefaultAsync(m => m.ZKid == id);

            if (zkeeper == null)
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

            zkeeper = await _context.zkeeper.FindAsync(id);

            if (zkeeper != null)
            {
                _context.zkeeper.Remove(zkeeper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
