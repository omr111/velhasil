using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class hashCommentLikeMap : EntityTypeConfiguration<hashCommentLike>
    {
        public hashCommentLikeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("hashCommentLikes");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.hashCommentId).HasColumnName("hashCommentId");
            this.Property(t => t.userId).HasColumnName("userId");
        }
    }
}
