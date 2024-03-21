using JobMatchingWebMVC.Models;

namespace JobMatchingWebMVC.DTO
{
    public class UserDTO 
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateOnly BirthDay { get; set; }
        public List<string>? Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? Location { get; set; }
    }
}
