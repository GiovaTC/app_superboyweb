using System.ComponentModel.DataAnnotations.Schema;

namespace app_superboyweb.Models
{
    [Table("Identities")] // Asegura que el nombre de la tabla coincida
    public class Identity
    {
        public int Id { get; set; } // Primary key
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}