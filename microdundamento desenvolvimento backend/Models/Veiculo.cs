using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace microdundamento_desenvolvimento_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Ano de Fabricação!")]

        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Ano do Modelo!")]
        public int AnoModelo { get; set; }

    }
}
