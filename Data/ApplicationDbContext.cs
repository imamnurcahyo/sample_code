using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MstBoUser> Users { get; set; }
        public DbSet<MstBoRoleAccess> Roles { get; set; }
        public DbSet<MstBoMenu> Menus { get; set; }
        public DbSet<MstBoRoleMenuAccess> RoleMenuAccesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints
            modelBuilder.Entity<MstBoUser>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MstBoRoleMenuAccess>()
                .HasOne(rm => rm.Role)
                .WithMany(r => r.RoleMenuAccesses)
                .HasForeignKey(rm => rm.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MstBoRoleMenuAccess>()
                .HasOne(rm => rm.Menu)
                .WithMany(m => m.RoleMenuAccesses)
                .HasForeignKey(rm => rm.MenuId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
