using System.ComponentModel.DataAnnotations;

namespace AspLoginCore.Models
{
    public class Cliente
    {
        [Display(Name = "Código",Description ="Código.")]
        public int Id { get; set; }
        [Display(Name = "Nome completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome Completo é obrigatorio!")]
        public string Name { get; set; }
        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "A data é obrigatorio!")]
        public DateTime Nascimento { get; set; }
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O Sexo é obrigatorio!")]
        [StringLength(1,ErrorMessage ="Deve conter 1 char!")]
        public string Sexo { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio!")]
        public string CPF { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O Celular é obrigatorio!")]
        public string Telefone { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O E-mail é obrigatorio!")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Informe um email valido...")]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A senha é obrigatorio!")]
        [StringLength(6,MinimumLength = 6,ErrorMessage ="A senha dever ter 6 digitos")]
        public string Senha { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "A situação é obrigatorio!")]
        public string Situação { get; set; }
    }
}
