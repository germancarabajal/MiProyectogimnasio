using System.ComponentModel.DataAnnotations;

namespace MiProyectogimnasio.Models
{
    public class Socio
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Dni es obligatorio")]
        public int Dni { get; set; }

        [MaxLength(30, ErrorMessage = "La longitud maxima es de 30 caracteres")]
        public string Direccion { get;set; }

  

    }
}
