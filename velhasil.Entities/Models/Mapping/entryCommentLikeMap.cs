using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class entryCommentLikeMap : EntityTypeConfiguration<entryCommentLike>
    {
        public entryCommentLikeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("entryCommentLikes");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.entryCommentId).HasColumnName("entryCommentId");

            // Relationships
            this.HasRequired(t => t.entryComment)
                .WithMany(t => t.entryCommentLikes)
                .HasForeignKey(d => d.entryCommentId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.entryCommentLikes)
                .HasForeignKey(d => d.userId);

        }
    }
}
