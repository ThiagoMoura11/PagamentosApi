using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PagamentosApi.Domain.Entites;


namespace PagamentosApi.Infrastructure.Map
{
    public class TransacaoPixConfiguration : IEntityTypeConfiguration<TransacaoPix>
    {
        public void Configure(EntityTypeBuilder<TransacaoPix> builder)
        {
            builder.ToTable("TransacaoPix");
            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Pagamento)
                .WithMany()
                .HasForeignKey(t => t.PagamentoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.ChavePix)
                .WithMany()
                .HasForeignKey(t => t.ChavePixId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.DataTransacao)
                .IsRequired();
        }
    }
}
