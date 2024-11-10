using Microsoft.EntityFrameworkCore;

namespace MemorizeAppApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}