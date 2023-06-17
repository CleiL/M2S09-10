using labclothingcollectionbd.Models;

namespace labclothingcollectionbd.Mockusuario
{
    public static class MockUsuario
    {
        public static IList<Usuario> Usuarios = new List<Usuario>()
        {
                new Usuario { Id = Guid.Parse("255481ac-7faf-4f2d-b96c-430786bd3933"), Nome = "Leticia Lorena Isabela da Mata", Email = "leticia.lorena.damata@alemponte.com.br", Cpf = "67972801843", Genero = "Feminino", Telefone = "(11) 99209-8724", Cnpj = "", Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("dadc1781-8a52-4fc9-bc62-b1638dc68c04"), Nome = "Cecilia e Diogo Marketing Ltda", Email = "juridico@ceciliaediogomarketingltda.com.br", Cnpj = "18818520000171" , Cpf = "", Genero = "Masculino", Telefone = "(11) 2986-4648" , Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("cf0902e8-8ab9-43d2-8d78-8a69ba1f2022"), Nome = "Nathan Hugo Vicente da Conceicao", Email = "nathanhugodaconceicao@danzarin.com.br", Cpf = "220893949", Cnpj = "", Genero = "Masculino", Telefone = "(17) 99698-2693" , Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("cfae8202-fbe7-4581-8807-7928074a7cf2"), Nome = "Yasmin e Raimunda Casa Noturna ME", Email = "ti@yasmineraimundacasanoturname.com.br", Cnpj = "27133457000120", Cpf = "", Genero = "Masculino", Telefone = "(17) 2813-3557", Tipo = TipoUsuario.Outro },
                new Usuario { Id = Guid.Parse("cbc7c9bf-0d6a-4504-8b94-bbfc4926de65"), Nome = "Anthony Enrico Sergio de Paula", Email = "anthony_enrico_depaula@texfuse.com.br", Cpf = "214678234", Cnpj = "" , Genero = "Masculino", Telefone = "(15) 99492-9411", Tipo = TipoUsuario.Outro }
        };
    }
}
