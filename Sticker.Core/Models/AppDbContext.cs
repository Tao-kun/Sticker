using Microsoft.EntityFrameworkCore;
using Sticker.Model;

namespace Sticker.Core.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<People> Peoples;
        public DbSet<Tag> Tags;
        public DbSet<StickerInfo> StickerInfos;
        public DbSet<StickerTag> StickerTags;
        public DbSet<StickerPeople> StickerPeoples;

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
                .HasIndex(p => p.PeopleName)
                .IsUnique();
            modelBuilder.Entity<Tag>()
                .HasIndex(t => t.TagName)
                .IsUnique();
            modelBuilder.Entity<StickerInfo>()
                .HasIndex(s => s.FileName)
                .IsUnique();

            modelBuilder.Entity<StickerTag>()
                .HasKey(st => new
                {
                    st.StickerInfoId, st.TagId
                });
            modelBuilder.Entity<StickerPeople>()
                .HasKey(sp => new
                {
                    sp.StickerInfoId, sp.PeopleId
                });
        }
    }
}