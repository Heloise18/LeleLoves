using Microsoft.EntityFrameworkCore;

namespace LeleLoves.Models;

public class LeleLovesDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Like> Likes => Set<Like>();
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Like>()
            .HasOne(l => l.User)
            .WithMany(u => u.Likes)
            .HasForeignKey(l => l.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Like>()
            .HasOne(l => l.UserLiked)
            .WithMany(u => u.ReceivedLikes)
            .HasForeignKey(l => l.UserLikedID)
            .OnDelete(DeleteBehavior.NoAction);
        
        model.Entity<User>();

    }
}