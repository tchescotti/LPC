using System.ComponentModel.DataAnnotations;

namespace AppAssociados.Domain
{
    public class EstadoCivil
    {
        public int id { get; set; }

        [Required(ErrorMessage="Informe estado civil.", AllowEmptyStrings=false)]
        [StringLength(20, MinimumLength=6, ErrorMessage="Informe estado civil válido.")]
        public string descricao { get; set; }
    }
}