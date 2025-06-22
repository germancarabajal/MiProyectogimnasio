using System.ComponentModel.DataAnnotations;

namespace MiProyectogimnasio.Models
{
    public class Clase
    {
        [Key]   
        public int Id { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre de la clase")]
        public string NombreClase { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre del profesor que dicta la clase")]
        public string Profesor { get; set; }
        [Required(ErrorMessage ="Debe ingresar la hora en el formato '12:00'")]
        [DataType(DataType.Time)]
        public TimeSpan Horario {  get; set; }
        
    }
}
