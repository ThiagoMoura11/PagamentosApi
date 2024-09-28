using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PagamentosApi.Domain.Entites;


namespace PagamentosApi.Infrastructure.Map
{
    public class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ChavePix)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.DataPagamento)
                .IsRequired();
        }
    }
}
