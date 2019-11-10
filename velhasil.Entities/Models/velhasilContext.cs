using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using velhasil.Entities.Models.Mapping;

namespace velhasil.Entities.Models
{
    public partial class velhasilContext : DbContext
    {
        static velhasilContext()
        {
            Database.SetInitializer<velhasilContext>(null);
        }

        public velhasilContext()
            : base("Name=velhasilContext")
        {
        }

        public DbSet<ad> ads { get; set; }
        public DbSet<channel> channels { get; set; }
        public DbSet<entry> entries { get; set; }
        public DbSet<entryCommentLike> entryCommentLikes { get; set; }
        public DbSet<entryComment> entryComments { get; set; }
        public DbSet<hashCommentLike> hashCommentLikes { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<siteAbout> siteAbouts { get; set; }
        public DbSet<sss> ssses { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<termsOfUse> termsOfUses { get; set; }
        public DbSet<ticket> tickets { get; set; }
        public DbSet<userEntry> userEntries { get; set; }
        public DbSet<userRole> userRoles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new adMap());
            modelBuilder.Configurations.Add(new channelMap());
            modelBuilder.Configurations.Add(new entryMap());
            modelBuilder.Configurations.Add(new entryCommentLikeMap());
            modelBuilder.Configurations.Add(new entryCommentMap());
            modelBuilder.Configurations.Add(new hashCommentLikeMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new roleMap());
            modelBuilder.Configurations.Add(new siteAboutMap());
            modelBuilder.Configurations.Add(new sssMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new termsOfUseMap());
            modelBuilder.Configurations.Add(new ticketMap());
            modelBuilder.Configurations.Add(new userEntryMap());
            modelBuilder.Configurations.Add(new userRoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
