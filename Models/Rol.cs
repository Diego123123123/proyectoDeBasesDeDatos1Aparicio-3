using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        public string Nombre { get; set; }
    }
}