using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HurtadoBackend.Modelos
{
    public class Usuario
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String UsrNombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String UsrClave { get; set; }

        public Boolean UsrEstado { get; set; }

        //////////////////////////////////////////////

        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}
