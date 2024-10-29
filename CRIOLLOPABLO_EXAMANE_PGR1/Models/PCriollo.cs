using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRIOLLOPABLO_EXAMANE_PGR1.Models
{
    public class PCriollo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0, 200, ErrorMessage = "Ingrese el peso en Cm")]
        public float Altura { get; set; }
        [Required]
        public bool Discapacidad { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Celular")]
        [Display(Name = "Número celular")]
        public int IdCelular { get; set; }
        public Celular celular { get; set; }


    }
}
