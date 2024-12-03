using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fornecedores.Models
{
    public class Fornecedor

    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string RazaoSocial { get; set; }

        [MaxLength(150)]
        public string NomeFantasia { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        // Endereço detalhado
        [Required]
        [MaxLength(200)]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }

        [MaxLength(50)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        [Required]
        [MaxLength(10)]
        public string CEP { get; set; }

        [MaxLength(100)]
        public string NomePessoaContato { get; set; }
    }
}
