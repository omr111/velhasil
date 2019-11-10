using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class siteAboutMap : EntityTypeConfiguration<siteAbout>
    {
        public siteAboutMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.phone)
                .HasMaxLength(12);

            this.Property(t => t.address)
                .HasMaxLength(500);

            this.Property(t => t.tradeRegisterNo)
                .HasMaxLength(50);

            this.Property(t => t.instagram)
                .HasMaxLength(80);

            this.Property(t => t.facebook)
                .HasMaxLength(80);

            this.Property(t => t.twitter)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("siteAbout");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.tradeRegisterNo).HasColumnName("tradeRegisterNo");
            this.Property(t => t.instagram).HasColumnName("instagram");
            this.Property(t => t.facebook).HasColumnName("facebook");
            this.Property(t => t.twitter).HasColumnName("twitter");
        }
    }
}
