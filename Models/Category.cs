using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }
    }
}