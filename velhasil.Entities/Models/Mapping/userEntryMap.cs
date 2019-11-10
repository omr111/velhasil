using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class userEntryMap : EntityTypeConfiguration<userEntry>
    {
        public userEntryMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("userEntries");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.entryId).HasColumnName("entryId");
            this.Property(t => t.channelId).HasColumnName("channelId");

            // Relationships
            this.HasRequired(t => t.channel)
                .WithMany(t => t.userEntries)
                .HasForeignKey(d => d.channelId);
            this.HasRequired(t => t.entry)
                .WithMany(t => t.userEntries)
                .HasForeignKey(d => d.entryId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.userEntries)
                .HasForeignKey(d => d.userId);

        }
    }
}
