using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Person
    {
        [Key]
     
        public int PersonId { get; set; }
        
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        
        
        
    }
}