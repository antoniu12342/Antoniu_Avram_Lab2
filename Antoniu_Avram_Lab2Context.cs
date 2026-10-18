using Microsoft.EntityFrameworkCore;

public class Antoniu_Avram_Lab2Context(DbContextOptions<Antoniu_Avram_Lab2Context> options) : DbContext(options)
{
    public DbSet<Antoniu_Avram_Lab2.Models.Book> Book { get; set; } = default!;
    public object Publisher { get; internal set; }
}
