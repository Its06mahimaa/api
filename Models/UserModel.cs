using Google.Apis.Admin.Directory.directory_v1.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace trainingproject.Models
{
    public class UserModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string Mobile { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public string Hobbies { get; set; } = null!;

        [Required]
        public IFormFile Profilepic { get; set; } = null;

      
    }
}
