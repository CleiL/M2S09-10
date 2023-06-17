using labclothingcollectionbd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labclothingcollectionbd.Mappings
{
    public class UsuarioMap: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Genero);

            builder.Property(x => x.DataNascimento);

            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();

            builder.Property(x => x.Cnpj).HasMaxLength(14).IsRequired();

            builder.Property(x => x.Telefone).HasMaxLength(20);

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Tipo);

            builder.Property(x => x.Status);
        }
    }
}
