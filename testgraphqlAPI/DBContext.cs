using Microsoft.EntityFrameworkCore;

namespace testgraphqlAPI
{
    public class DBContext
    {
        public DbSet<User> Users { get; set; }
    }
}
