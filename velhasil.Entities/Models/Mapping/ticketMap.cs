using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class ticketMap : EntityTypeConfiguration<ticket>
    {
        public ticketMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.topicName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.message)
                .IsRequired();

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(70);

            // Table & Column Mappings
            this.ToTable("tickets");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.topicName).HasColumnName("topicName");
            this.Property(t => t.message).HasColumnName("message");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
