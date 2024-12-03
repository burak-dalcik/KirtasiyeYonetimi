using System.ComponentModel.DataAnnotations;

namespace Kirt_web.Models

{
    public class Users
    {
        [Key]
        public int userId { get; set; } 

        [Required]
        public String name { get; set; } = "";

        [Required]
        public String password { get; set; } = "";

        [Required]
        public String address { get; set; } = "";

        [Required]
        public String phonenumber { get; set; } = "";


    }
}

