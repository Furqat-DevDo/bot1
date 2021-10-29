using Microsoft.EntityFrameworkCore;

namespace bot.Entity
{                    // FOYDALANUVCHILARNI MA'LUMOTLAR BAZASIGA SAQLAB OLADIGAN KLASS.
    public class BotDbContext : DbContext 
    {
        public DbSet<BotUser> Users { get; set; }

        public BotDbContext(DbContextOptions<BotDbContext> options)
            :base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
        }
    }
}