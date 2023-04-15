using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entities
{
    public class User
    {
 
        public int Id { get; set; }

 
        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserName { get; set; }

    }
}
