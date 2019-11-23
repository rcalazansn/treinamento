using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI.ViewModels
{
    public class ProdutoAdicionarViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 4)]

        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "O valor deve estar entre {1} e {2}")]
        public decimal Valor { get; set; }
    }

    public class ProdutoEditarViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 4)]

        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "O valor deve estar entre {1} e {2}")]
        public decimal Valor { get; set; }
    }
}
