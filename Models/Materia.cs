using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Materia
    {
        [Key]
        public string NomMat { get; set; }
        
        public string Area { get; set; }
        
        public int Creditos { get; set; }
    }
}