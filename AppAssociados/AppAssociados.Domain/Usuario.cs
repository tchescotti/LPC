using System.ComponentModel.DataAnnotations;

namespace AppAssociados.Domain
{
    public class Usuario
    {
        public int id { get; set; }
        
        [Required(ErrorMessage="Informe nome de usuário.", AllowEmptyStrings=false)]
        public string usuario { get; set; }

        [Required(ErrorMessage="Informe a senha.", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength=6, ErrorMessage="Senha fora dos padrões. Tente novamente.")]
        public string senha { get; set; }
    }
}