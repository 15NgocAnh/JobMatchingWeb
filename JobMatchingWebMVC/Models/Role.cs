namespace JobMatchingWebMVC.Models
{
    public enum RoleEnum
    {
        ROLE_ADMIN = 1, 
        ROLE_MANAGER = 2,
        ROLE_USER = 3,
        ROLE_EMPLOYEE = 4,
        ROLE_EMPLOYER = 5
    }
    public class Role
    {
        public RoleEnum Roles { get; }
    }
}
