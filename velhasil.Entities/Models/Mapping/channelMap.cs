using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class channelMap : EntityTypeConfiguration<channel>
    {
        public channelMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.channelName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("channels");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.autohorId).HasColumnName("autohorId");
            this.Property(t => t.channelName).HasColumnName("channelName");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.channels)
                .HasForeignKey(d => d.autohorId);

        }
    }
}
