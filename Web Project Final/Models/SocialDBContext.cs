using Microsoft.EntityFrameworkCore;

namespace Web_Project_Final.Models
{
    public class SocialDBContext : DbContext
    {
        public SocialDBContext(DbContextOptions<SocialDBContext> options) : base(options)
        {

        }
        public DbSet<ContectDataModel> ContectDataModels { get; set; }
    }
}
