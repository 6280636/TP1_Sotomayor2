using Microsoft.EntityFrameworkCore;

namespace TP1_Sotomayor.Models.Data
{
    public class TP1DbContext : DbContext
    {
        public TP1DbContext(DbContextOptions<TP1DbContext> options) : base(options)
        {

        }

    }


}
