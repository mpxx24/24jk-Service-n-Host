using System.Data.Entity;

namespace _24jk
{
    public class Context : DbContext
    {
        public DbSet<DbFile> DbFiles { get; set; }
    }
}
