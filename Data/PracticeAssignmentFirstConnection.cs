using Microsoft.EntityFrameworkCore;
using PracticeAssignmentFirstConnection.Models;

namespace PracticeAssignmentFirstConnection.Data
{
    public class FistContext : DbContext
    {
        public FistContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Pet> Pets { get; set; }
    }
}
