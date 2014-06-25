using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure;

namespace Domain
{
    public class SimpleObjectMapping : EntityTypeConfiguration<SimpleObject>
    {
        public SimpleObjectMapping()
        {
            this.HasKey(t => t.SimpleObjectId);        
            this.ToTable("SimpleObject", "Simple");
            this.Property(t => t.SimpleObjectId).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name")
                                      .IsRequired()
                                      .HasMaxLength(30);
        }
    }
}