namespace HRMS.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedDate  { get; set; }
        public Role Role { get; set; }
    }
}
