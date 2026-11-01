using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Antoniu_Avram_Lab2.Models;

namespace Antoniu_Avram_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Antoniu_Avram_Lab2.Data.Antoniu_Avram_Lab2Context _context;

    public IndexModel(Antoniu_Avram_Lab2.Data.Antoniu_Avram_Lab2Context context)
    {
        _context = context;
    }

    // 1. Aici trebuie IList, NU DbSet (și o singură dată!)
    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // 2. Extragem lista din context
        if (_context.Publisher != null)
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    } // <--- Acolada care lipsea la linia 21-22 și închide metoda OnGetAsync
} // <--- Acolada care închide clasa IndexModel} // <--- Acolada care închide namespace-ul
