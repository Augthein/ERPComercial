using UsersClearance.Models;

namespace Users.Models{
    public class User {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Clearance Clearance { get; set; } = Clearance.None;

        public string FirstName { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; } = new DateTime(1416,1,16);
        public string Phone { get; set; } = "188";
        public string Email { get; set; } = "email@email.com";
    }
}