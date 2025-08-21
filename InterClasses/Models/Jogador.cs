using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "O Nome do Jogador é Obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Jogador pode ter, no máximo, 50 caracteres.")]
        [Display(Name = "Nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O Número do Jogador é Obrigatório.")]
        [Range(1, 99, ErrorMessage = "O Número do Jogador deve estar entre 1 e 99.")]
        [Display(Name = "Número do Jogador")]
        public int Numero { get; set; }
        public string? Posicao { get; set; }

        // Relacionando Jogador X Time
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
