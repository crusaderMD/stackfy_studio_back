using System.ComponentModel.DataAnnotations;

namespace stackfy_studio_back.Models
{
    public class ContatoModel
    {
        [Required]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string? Telefone { get; set; }

        [Required]
        public string Servico { get; set; }

        public string? Orcamento { get; set; }

        [Required]
        public string Mensagem { get; set; }

        public string? Origem { get; set; }
    }
}
