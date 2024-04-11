using System.ComponentModel.DataAnnotations;

namespace AspLoginCore.Models
{
    public class Colaborador
    {
        [Display(Name = "Código", Description = "Código.")]
        public int Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatorio.")]
        public string Nome { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O celular é obrigatorio.")]
        public string Telefone { get; set; }


        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio.")]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O email não é valido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email valido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatorio.")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 carcacteres")]
        public string Senha { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O tipo é obrigatorio")]
        public string Tipo { get; set; }
    }
}
