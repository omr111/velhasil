using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class userRoleMap : EntityTypeConfiguration<userRole>
    {
        public userRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("userRoles");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.roleId).HasColumnName("roleId");

            // Relationships
            this.HasRequired(t => t.role)
                .WithMany(t => t.userRoles)
                .HasForeignKey(d => d.roleId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.userRoles)
                .HasForeignKey(d => d.userId);

        }
    }
}
