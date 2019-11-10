using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class entryMap : EntityTypeConfiguration<entry>
    {
        public entryMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.entryCaption)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("entries");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.entryCaption).HasColumnName("entryCaption");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.channelId).HasColumnName("channelId");

            // Relationships
            this.HasRequired(t => t.channel)
                .WithMany(t => t.entries)
                .HasForeignKey(d => d.channelId);

        }
    }
}
