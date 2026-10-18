using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Antoniu_Avram_Lab2.Models;

namespace Antoniu_Avram_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Antoniu_Avram_Lab2Context _context;

    public IndexModel(Antoniu_Avram_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book.ToListAsync();
        Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
    }
}
