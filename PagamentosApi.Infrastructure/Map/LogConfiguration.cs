using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PagamentosApi.Domain.Entites.GrupoPadraoCheckInApi.Domain.Entities;


namespace PagamentosApi.Infrastructure.Map
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log");
            builder.HasKey(l => l.IdLog);

            builder.Property(l => l.DataLog)
                .IsRequired();

            builder.Property(l => l.NivelLog)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(l => l.MensagemLog)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(l => l.ExcecaoLog)
                .HasMaxLength(2000);

            builder.Property(l => l.OrigemLog)
                .HasMaxLength(200);

            builder.Property(l => l.DadosLog)
                .HasMaxLength(2000);
        }
    }
}
