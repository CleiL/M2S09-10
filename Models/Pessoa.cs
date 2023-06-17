using System.ComponentModel.DataAnnotations;

namespace labclothingcollectionbd.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public string? Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public string? Telefone { get; set; }
    }
}
