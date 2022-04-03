using WebApplication28.Models;

namespace WebApplication28.Models
{
    internal class joins
    {
        public Role roles { get; set; }
        public User users { get; set; }
        public Login logins { get; set; }
        public Salary salaries { get; set; }
        public Service services { get; set; }
        public UserService userService { get; set; }
        public Review review { get; set; }

        public Payment payment { get; set; }
    }
}