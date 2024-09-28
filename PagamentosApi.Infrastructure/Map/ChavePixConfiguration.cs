using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PagamentosApi.Domain.Entites;


namespace PagamentosApi.Infrastructure.Map
{
    public class ChavePixConfiguration : IEntityTypeConfiguration<ChavePix>
    {
        public void Configure(EntityTypeBuilder<ChavePix> builder)
        {
            builder.ToTable("ChavePix");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.TipoChave)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.ValorChave)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(c => c.Cliente)
                .WithMany(c => c.ChavesPix)
                .HasForeignKey(c => c.ClienteId);
        }
    }
}
