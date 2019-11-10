using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class sssMap : EntityTypeConfiguration<sss>
    {
        public sssMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.quention)
                .IsRequired();

            this.Property(t => t.answer)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("sss");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.quention).HasColumnName("quention");
            this.Property(t => t.answer).HasColumnName("answer");
        }
    }
}
