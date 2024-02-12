using System.ComponentModel.DataAnnotations;

namespace MagiVilla.Modelos.Dto
{// este es el modelo que se utiliza en la base de datos del programa o los atributos de la clase
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public string detalle { get; set; }
        [Required]
        public double  Tarifa { get; set; }

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }

        public string ImageUrl { get; set; }

        public string Amenidad { get; set; }

    }
}
