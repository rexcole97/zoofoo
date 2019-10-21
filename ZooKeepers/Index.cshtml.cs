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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<zkeeper> zkeeper { get;set; }

        public async Task OnGetAsync()
        {
            zkeeper = await _context.zkeeper.ToListAsync();
        }
    }
}
