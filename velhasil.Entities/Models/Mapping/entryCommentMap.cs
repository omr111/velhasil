using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class entryCommentMap : EntityTypeConfiguration<entryComment>
    {
        public entryCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.entryComment1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("entryComments");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.entryComment1).HasColumnName("entryComment");
            this.Property(t => t.entryId).HasColumnName("entryId");
            this.Property(t => t.likeCount).HasColumnName("likeCount");

            // Relationships
            this.HasRequired(t => t.entry)
                .WithMany(t => t.entryComments)
                .HasForeignKey(d => d.entryId);

        }
    }
}
