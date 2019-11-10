using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class adMap : EntityTypeConfiguration<ad>
    {
        public adMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.caption)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.adUrl)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ads");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.caption).HasColumnName("caption");
            this.Property(t => t.adUrl).HasColumnName("adUrl");
        }
    }
}
