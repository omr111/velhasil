using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class termsOfUseMap : EntityTypeConfiguration<termsOfUse>
    {
        public termsOfUseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.term });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.term)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("termsOfUse");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.term).HasColumnName("term");
        }
    }
}
