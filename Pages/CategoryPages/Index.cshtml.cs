using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Antoniu_Avram_Lab2.Data;

namespace Antoniu_Avram_Lab2.Pages.CategoryPages;

public class IndexModel : PageModel
{
    private readonly Antoniu_Avram_Lab2Context _context;

    public IndexModel(Antoniu_Avram_Lab2Context context)
    {
        _context = context;
    }

    public IList<Category> Category { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Category = await _context.Category.ToListAsync();
    }
}
