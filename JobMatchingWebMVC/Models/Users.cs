using JobMatchingWebMVC.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobMatchingWebMVC.Models
{
    [Table("users")]
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

        [Required]
        public string? UserName { get; set; }
        public DateOnly BirthDay { get; set; }
        public List<string>? Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? Location { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsMale { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        public List<Roles> Roles { get; set; } = null!;

        public static string EncodePasswordToBase64(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password));
            }

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
        //this function Convert to Decord your Password
        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }

}
