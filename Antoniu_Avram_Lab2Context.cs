global using Antoniu_Avram_Lab2.Data;
using Antoniu_Avram_Lab2.Models;
using Microsoft.EntityFrameworkCore;


namespace Antoniu_Avram_Lab2.Data
{
    public class Antoniu_Avram_Lab2Context : DbContext
    {
        public DbSet<Category> Category { get; set; } = default!;
        public Antoniu_Avram_Lab2Context(DbContextOptions<Antoniu_Avram_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;

        // Aici este locul lui:
        public DbSet<Publisher> Publisher { get; set; } = default!;
        
    }
}