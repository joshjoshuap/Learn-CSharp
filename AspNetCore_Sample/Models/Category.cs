using System.ComponentModel.DataAnnotations;

namespace ASPNETCORE_Basics.Models
{
    public class Category
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Required to fillup
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

    }
}
