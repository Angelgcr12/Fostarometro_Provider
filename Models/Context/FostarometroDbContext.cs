using Microsoft.EntityFrameworkCore;

namespace FostarometroAPI.Models.Context
{

    public class FostarometroDbContext : DbContext
    {
        public FostarometroDbContext(DbContextOptions<FostarometroDbContext> options) : base(options)
        {
        }
    }
}