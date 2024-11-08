using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    public class Logins
    {
        [Key]
        public int id_Logins { get; set; } 
        public string Login { get; set; }
        public string Password { get; set; }

        [Required]
        [ForeignKey("Users")]
        public string User_id { get; set; }
        public Users Users { get; set; }
    }
}
