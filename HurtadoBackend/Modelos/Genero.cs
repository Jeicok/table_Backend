using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HurtadoBackend.Modelos
{
    public class Genero
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String GnrNombre { get; set; }
        public Boolean GnrEstado { get; set; }
    }
}
