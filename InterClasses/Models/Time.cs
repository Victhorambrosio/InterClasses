using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Time
    {
        public int TimeId { get; set; } //Chave Primária (Id)

        [Required(ErrorMessage = "O Nome do Time é Obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Time pode ter, no máximo, 50 caracteres.")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        // Relacionamento entre Models (Tabelas no Banco de Dados)
        // Chave Estrangeira (Busca de outra Tabela)
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vincular o campo do Id da Tabela.
        public Esporte? Esporte { get; set; } // Vincular o Objeto relacionado ao Id acima.
    }
}
