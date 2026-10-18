using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Antoniu_Avram_Lab2.Models;

namespace Antoniu_Avram_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Antoniu_Avram_Lab2Context _context;

    public IndexModel(Antoniu_Avram_Lab2Context context)
    {
        _context = context;
    }

    public DbSet<Publisher> Publisher { get; set; }

    public async Task OnGetAsync()
    {
        Publisher = await _context.Set<Publisher>().ToListAsync();
    }
}
