using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace velhasil.Entities.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.message1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("messages");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.fromWhoId).HasColumnName("fromWhoId");
            this.Property(t => t.message1).HasColumnName("message");
            this.Property(t => t.whomId).HasColumnName("whomId");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.fromWhoId);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.messages1)
                .HasForeignKey(d => d.whomId);

        }
    }
}
