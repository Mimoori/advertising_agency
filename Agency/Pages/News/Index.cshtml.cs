using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agency.Data;
using Agency.Models;

namespace Agency.Pages.News
{
    public class IndexModel : PageModel
    {
        private readonly Agency.Data.ApplicationContext _context;

        public IndexModel(Agency.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Article = await _context.article.ToListAsync();
        }
    }
}
