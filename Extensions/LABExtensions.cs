using labclothingcollectionbd.Models;
using Microsoft.EntityFrameworkCore;

namespace labclothingcollectionbd.Extensions
{
    public static class LABExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = Guid.Parse("234dcba3-095e-4fa4-b6e9-8ed8985974d0"), Nome = "Usuario Mestre", Email = "usuarioMestre@usuario.com.br", Cpf = "61630089010", Genero = "Feminino", Telefone = "(51) 98772-4231", Cnpj = "", Tipo = TipoUsuario.Administrador },
                new Usuario { Id = Guid.Parse("835cdc27-8b32-417f-a0cd-e1fd2e8de15d"), Nome = "Davi e Sandra Marketing Ltda", Email = "representantes@daviesandramarketingltda.com.br", Cnpj = "10852072000110", Cpf = "", Genero = "Masculino", Telefone = "(11) 3825-9493", Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("9c2dfca7-1e8b-4569-918c-38a186b41433"), Nome = "Geraldo Gustavo Henry Porto", Email = "geraldo-porto83@bzness.com.br", Cpf = "20985331011", Cnpj = "", Genero = "Masculino", Telefone = "(11) 98108-0228", Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("f6ede7d3-05c2-4017-b8bb-e0dc9eac74d5"), Nome = "Renan e Manoel Esportes ME", Email = "almoxarifado@renanemanoelesportesme.com.br", Cnpj = "27133457000120", Cpf = "", Genero = "Masculino", Telefone = "(19) 98676-5965", Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("1e980517-a3ea-44b3-800c-d6389a83aadc"), Nome = "Mario Ruan Cesar Figueiredo", Email = "mario-figueiredo98@santosdumonthospital.com", Cpf = "47065411079", Cnpj = "", Genero = "Masculino", Telefone = "(19) 2610-6390", Tipo = TipoUsuario.Outro }
                );
            return builder;
        }
    }
}
