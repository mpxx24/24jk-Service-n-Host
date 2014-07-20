using System.Data.Entity;

namespace _24jk
{
    public class Context : DbContext
    {
        public DbSet<Pic> Pics { get; set; }
        public DbSet<PicList> PicLists { get; set; }
    }
}
