using JobMatchingWebMVC.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMatchingWebMVC.Models
{
    [Table(name:"users")]
    public class Users
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [MinLength(8)]
        public string? Password { get; set; }

        [Required]
        [StringLength(100)]
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public DateOnly BirthDay { get; set; }
        public List<string>? Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? Location { get; set; }
        [Required]
        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsMale { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public Role Role { get; set; }
    }

}
